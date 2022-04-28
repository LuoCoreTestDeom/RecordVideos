using Accord.Controls;
using Accord.Video;
using Accord.Video.DirectShow;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accord_OpenCV
{
    public partial class Frm_AccordOpenCV : Form
    {
        public Frm_AccordOpenCV()
        {
            InitializeComponent();
        }
        FilterInfoCollection _videoDevices;
        VideoCaptureDevice _videoSource;
        VideoCapabilities[] _videoCapabilities;

        private void Frm_AccordOpenCV_Load(object sender, EventArgs e)
        {
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CB_Camera.Items.Clear();
            if (_videoDevices.Count != 0)
            {
                foreach (FilterInfo device in _videoDevices)
                {
                    CB_Camera.Items.Add(device.Name);
                }
            }
            else
            {
                CB_Camera.Items.Add("No DirectShow devices found");
            }
            CB_Camera.SelectedIndex = 0;
        }

        private void CB_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            _videoSource = new VideoCaptureDevice(_videoDevices[CB_Camera.SelectedIndex].MonikerString);//连接摄像头。
            _videoCapabilities = _videoSource.VideoCapabilities;
            CB_CameraResolution.Items.Clear();
            if (_videoCapabilities.Length == 0)
            {
                CB_CameraResolution.Items.Add("Not supported");
            }
            else
            {
                foreach (VideoCapabilities capabilty in _videoCapabilities)
                {
                    CB_CameraResolution.Items.Add(capabilty.FrameSize.ToString() + "," + capabilty.MaximumFrameRate.ToString() + "fps," + capabilty.BitCount + " codec");
                }
            }
            CB_CameraResolution.SelectedIndex = 1;
        }
        private void 摄像头参数_Click(object sender, EventArgs e)
        {
            if (_videoSource != null)
                _videoSource.DisplayPropertyPage(IntPtr.Zero);
        }

        private void 开启摄像头_Click(object sender, EventArgs e)
        {
           

            if (CB_Camera.SelectedIndex < 0|| CB_CameraResolution.SelectedIndex < 0)
            {
                MessageBox.Show("没有选择摄像头");
                return;
            }
            _videoSource.VideoResolution = _videoSource.VideoCapabilities[CB_CameraResolution.SelectedIndex];
            videoSourcePlayer1.VideoSource = _videoSource;
            videoSourcePlayer1.NewFrame += VideoSourcePlayer1_NewFrame; ;
            videoSourcePlayer1.Start();
            开启摄像头.Enabled = false;
        }
        /// 录像
        /// </summary>
        public VideoWriter _videoWriter;
        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
{
            if (_videoWriter != null)
            {
                Mat mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(image);
                _videoWriter.Write(mat);
            }
        }

        private void 录像_Click(object sender, EventArgs e)
        {
            var vrSocrd = _videoSource.VideoResolution;
            System.Drawing.Size videoSize = vrSocrd.FrameSize;
            _videoWriter = new VideoWriter("a.mp4", FourCC.H264, vrSocrd.AverageFrameRate, new OpenCvSharp.Size() { Width = videoSize.Width, Height = videoSize.Height }, true);
            录像.Enabled = false;
        }

        private void 停止录像_Click(object sender, EventArgs e)
        {
            // 释放资源
            _videoWriter.Release();
            _videoWriter = null;
            录像.Enabled = true;
        }
    }
}
