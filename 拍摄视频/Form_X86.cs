
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AForge.Video.FFMPEG;
using AForge.Video;
using Accord.Video;
using System.Reflection.Emit;
using Accord.Math;

namespace 拍摄视频
{
    public partial class Form_X86 : Form
    {
        public Form_X86()
        {
            InitializeComponent();
        }
        private FilterInfoCollection videoDevices; //摄像头设备
        private Accord.Video.DirectShow.VideoCaptureDevice videoSource;   //视频的来源选择
        private Accord.Video.FFMPEG.VideoFileWriter writer;   //写入到视频


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in videoDevices)
            {
                comboBoxAttachedCameras.Items.Add(VideoCaptureDevice.Name);
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
                //videoSourcePlayer1.VideoSource =(AForge.Video.IVideoSource) videoSource;
                //videoSourcePlayer1.Start();

                videoSource.Start();
                videoSource.NewFrame += VideoSource_NewFrame1;


                BtnStart.Enabled = false;
                comboBoxAttachedCameras.Enabled = false;
                comboBoxSupportedModes.Enabled = false;

            }
        }

        private void comboBoxAttachedCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoSource = new Accord.Video.DirectShow.VideoCaptureDevice(videoDevices[comboBoxAttachedCameras.SelectedIndex].MonikerString);
            comboBoxSupportedModes.Items.Clear();
            comboBoxSupportedModes.Text = "";
            foreach (var capability in videoSource.VideoCapabilities)
            {
                comboBoxSupportedModes.Items.Add(capability.FrameSize.ToString() + "," + capability.MaximumFrameRate.ToString() + "fps," + capability.BitCount + " codec" + capability.GetHashCode());
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

        private void 开始录像_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                BtnSavedir_Click(null, null);
            }
            //var vcd = ((VideoCaptureDevice)videoSourcePlayer1.VideoSource);
            //System.Drawing.Size videoSize = vcd.VideoResolution.FrameSize;
            //VideoCaptureDevice cameraImage = (VideoCaptureDevice)videoSourcePlayer1.VideoSource;

            System.Drawing.Size videoSize = videoSource.VideoResolution.FrameSize;
            Accord.Video.DirectShow.VideoCaptureDevice cameraImage = (Accord.Video.DirectShow.VideoCaptureDevice)videoSource;
            writer = new Accord.Video.FFMPEG.VideoFileWriter();
          
          var vr=  cameraImage.VideoResolution;
            writer.Open(textBox1.Text, vr.FrameSize.Width, vr.FrameSize.Height, vr.AverageFrameRate);

        }

        private void VideoSource_NewFrame1(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap =new Bitmap(eventArgs.Frame);

            if (bitmap == null|| pictureBox1.Image== bitmap) 
            { 
                return; 
            }
            try
            {
                if (bitmap != null)
                {
                    if (writer != null && writer.IsOpen)
                    {
                        writer.WriteVideoFrame(new Bitmap(bitmap));
                    }

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = new Bitmap(bitmap);
                }
                bitmap.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                label4.BeginInvoke(new EventHandler(delegate
                {
                    label4.Text = ex.Message;
                }));
            }

        }

        //新帧的触发函数
        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = eventArgs.Frame;
            Bitmap saveImage = new Bitmap(Image.FromHbitmap(bitmap.GetHbitmap()));

            writer.WriteVideoFrame(saveImage);
            pictureBox1.Image = saveImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSource.NewFrame -= VideoSource_NewFrame1;
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.Stop();
            videoSourcePlayer1.Dispose();
            videoSource.Stop();
            writer.Close();
        }

        public static Bitmap DeepClone(Bitmap bitmap)
        {
            Bitmap dstBitmap = null;
            using (MemoryStream mStream = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(mStream, bitmap);
                mStream.Seek(0, SeekOrigin.Begin);
                dstBitmap = (Bitmap)bf.Deserialize(mStream);
                mStream.Close();
            }
            return dstBitmap;
        }
    }
}
