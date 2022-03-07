using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.DirectShow;
using Accord.Video.FFMPEG;

namespace Accord视频拍摄
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices; //摄像头设备
        private VideoCaptureDevice videoSource;   //视频的来源选择
        private VideoFileWriter videoWriter;   //写入到视频
        public Form1()
        {
            InitializeComponent();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in videoDevices)
            {
                comboBoxAttachedCameras.Items.Add(VideoCaptureDevice.Name);
            }
        }
        private void comboBoxAttachedCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[comboBoxAttachedCameras.SelectedIndex].MonikerString);
            comboBoxSupportedModes.Items.Clear();
            comboBoxSupportedModes.Text = "";
            foreach (var capability in videoSource.VideoCapabilities)
            {
                comboBoxSupportedModes.Items.Add(capability.FrameSize.ToString() + "," + capability.MaximumFrameRate.ToString() + "fps," + capability.BitCount + " codec" + capability.GetHashCode());
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxAttachedCameras.Text))
            {
                comboBoxAttachedCameras.SelectedIndex = 0;
                comboBoxAttachedCameras_SelectedIndexChanged(null, null);
            }
            if (string.IsNullOrWhiteSpace(comboBoxSupportedModes.Text))
            {
                comboBoxSupportedModes.SelectedIndex = 0;
            }
            if (BtnStart.Enabled)
            {
                videoSource.VideoResolution = videoSource.VideoCapabilities[comboBoxSupportedModes.SelectedIndex];
                videoSourcePlayer1.VideoSource = videoSource;
                videoSourcePlayer1.Start();
                BtnStart.Enabled = false;
                comboBoxAttachedCameras.Enabled = false;
                comboBoxSupportedModes.Enabled = false;
            }
        }

        private void 开始录像_Click(object sender, EventArgs e)
        {
            if (开始录像.Enabled)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    BtnSavedir_Click(null, null);
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("请选择路径！");
                    return;
                }
                开始录像.Enabled = false;
                var vcd = ((VideoCaptureDevice)videoSourcePlayer1.VideoSource);
                videoWriter = new VideoFileWriter();
                var vr = vcd.VideoResolution;
                videoWriter.Open(textBox1.Text, vr.FrameSize.Width, vr.FrameSize.Height, vr.AverageFrameRate);
                videoSourcePlayer1.NewFrame += VideoSourcePlayer1_NewFrame;
            }
        }

        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            if (videoWriter != null && videoWriter.IsOpen)
            {
                videoWriter.WriteVideoFrame(image);
            }
        }

        private void BtnSavedir_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = "video1";
                dialog.DefaultExt = ".mp4";
                dialog.Filter = "mp4文件 | *.mp4";
                dialog.AddExtension = true;
                var dialogresult = dialog.ShowDialog();
                textBox1.Text = dialog.FileName;
            }
        }

        private void 停止录像_Click(object sender, EventArgs e)
        {
            
            videoSourcePlayer1.NewFrame -= VideoSourcePlayer1_NewFrame;
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.Stop();
            videoSourcePlayer1.Dispose();
            videoSource.Stop();
            if (videoWriter != null)
                videoWriter.Dispose();
            开始录像.Enabled = true;
        }
    }
}
