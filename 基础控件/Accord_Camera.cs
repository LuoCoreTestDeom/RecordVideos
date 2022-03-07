using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Accord.Imaging;
using Accord.Controls;
using Accord.Video.FFMPEG;
using System.Drawing;
using Accord.Video.DirectShow;

namespace BaserControlLibrary.WinForm
{
    public partial class Accord_Camera : System.Windows.Forms.GroupBox, IDisposable
    {
        #region 公共参数
        public VideoSourcePlayer _VIDEOSOURCEPLAYER;
        private VideoCaptureDevice videoSource;   //视频的来源选择
        private VideoFileWriter videoWriter;   //写入到视频

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        #endregion
        public Accord_Camera()
        {
            this.Name = "Accord_Camera";
            this.Size = new System.Drawing.Size(333, 264);
            this.Font = new System.Drawing.Font("黑体", 20F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(333, 264);
            this._VIDEOSOURCEPLAYER = new VideoSourcePlayer();

            InitializeComponent();
            this._VIDEOSOURCEPLAYER.BackColor = System.Drawing.Color.OldLace;
            this._VIDEOSOURCEPLAYER.Dock = System.Windows.Forms.DockStyle.Fill;
            this._VIDEOSOURCEPLAYER.Location = new System.Drawing.Point(3, 34);
            this._VIDEOSOURCEPLAYER.Name = "_VIDEOSOURCEPLAYER";
            this._VIDEOSOURCEPLAYER.Size = new System.Drawing.Size(327, 227);
            this._VIDEOSOURCEPLAYER.TabIndex = 99999999;
            this._VIDEOSOURCEPLAYER.Text = "_VIDEOSOURCEPLAYER";
            this._VIDEOSOURCEPLAYER.VideoSource = null;
            this.Controls.Add(this._VIDEOSOURCEPLAYER);


        
            this.MouseDown += AForge_Camera_MouseDown;
            if (this.GetTopLevel())
            {
                this.SetTopLevel(true);
                this.BringToFront();
            }

        }


        private void AForge_Camera_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage((int)this.Handle, 0xA1, 2, 0);
        }


        public void Disposed()
        {
            if ((_VIDEOSOURCEPLAYER != null && _VIDEOSOURCEPLAYER.IsRunning))
            {
                _VIDEOSOURCEPLAYER.NewFrame -= VideoSourcePlayer1_NewFrame;
                _VIDEOSOURCEPLAYER.Stop();
                _VIDEOSOURCEPLAYER.SignalToStop();
                _VIDEOSOURCEPLAYER.WaitForStop();
                _VIDEOSOURCEPLAYER.Dispose();
                _VIDEOSOURCEPLAYER = null;
            }
            videoSource.Stop();
            if (videoWriter != null)
                videoWriter.Dispose();
        }

        private string myPhotoError = "没有找到摄像设备,请联系[瑞康]购买。";
        [Browsable(true)]
        [Description("找不到摄像头错误信息"), Category("摄像头错误信息"), DefaultValue(false)]
        public string MyPhotoError { get => myPhotoError; set => myPhotoError = value; }


        [Browsable(true)]
        [Description("是否开启摄像头"), Category("拍照"), DefaultValue(false)]
        public void MyPhoto(bool photoH)
        {

            if (photoH)
            {
                Form_SelectAccordCamera selectCamera = new Form_SelectAccordCamera();
                selectCamera.EventSelectComfirmCamera += SelectCamera_EventSelectComfirmCamera;
                selectCamera.ShowDialog();
            }
            else
            {
                Disposed();
            }
            this.Visible = photoH;
        }
        #region 开始记录视频文件
        public void OpenVideoWriter(string filePath)
        {
            var vcd = ((VideoCaptureDevice)_VIDEOSOURCEPLAYER.VideoSource);
            videoWriter = new VideoFileWriter();
            var vr = vcd.VideoResolution;
            videoWriter.Open(filePath, vr.FrameSize.Width, vr.FrameSize.Height, vr.AverageFrameRate);
            _VIDEOSOURCEPLAYER.NewFrame += VideoSourcePlayer1_NewFrame;
        }
        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            if (videoWriter != null && videoWriter.IsOpen)
            {
                videoWriter.WriteVideoFrame(image);
            }
        }
        #endregion 开始记录视频文件

        private void SelectCamera_EventSelectComfirmCamera(Form_SelectAccordCamera F, VideoCaptureDevice vcd)
        {
            _VIDEOSOURCEPLAYER.VideoSource = vcd;
            _VIDEOSOURCEPLAYER.Start();
            F.Close();
        }
    }
}
