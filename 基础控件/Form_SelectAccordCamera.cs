
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

namespace BaserControlLibrary.WinForm
{
    public partial class Form_SelectAccordCamera : Form
    {
        #region 全局参数
        FilterInfoCollection _VideoDevices;
        public VideoCaptureDevice _VideoSource;
        private VideoCapabilities[] videoCapabilities;
        private bool QJ_State=true;
        #endregion
        public Form_SelectAccordCamera()
        {
            InitializeComponent();
        }
        public Form_SelectAccordCamera(bool state)
        {
            QJ_State = state;
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
           
            _VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (_VideoDevices.Count <= 0) 
            { 
                MessageBox.Show("没有找到摄像设备,请联系[瑞康]购买。");
                if (!QJ_State)
                {
                    EventSelectComfirmCamera(this, null);
                }
                return; 
            }
            _VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            Cb_Camera.Items.Clear();
            if (_VideoDevices.Count != 0)
            {
                foreach (FilterInfo device in _VideoDevices)
                {
                    Cb_Camera.Items.Add(device.Name);
                }
            }
            else
            {
                Cb_Camera.Items.Add("没有找到摄像头！");
            }
            Cb_Camera.SelectedIndex = 0;
            SetCamera(Cb_Camera.SelectedIndex);
            if (!QJ_State) 
            {
                Btn_Comfirm_Click(null, null);
            }
        }

        public void SetCamera(int cameraIndex)
        {
            _VideoSource = new VideoCaptureDevice(_VideoDevices[cameraIndex].MonikerString);//连接摄像头。
            videoCapabilities = _VideoSource.VideoCapabilities;


            Cb_CameraResolution.Items.Clear();
            if (videoCapabilities.Length == 0)
            {
                Cb_CameraResolution.Items.Add("没有可选分辨率！");
            }
            else
            {
                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    Cb_CameraResolution.Items.Add(string.Format("{0} x {1}", capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }
            }
            Cb_CameraResolution.SelectedIndex = 1;
        }

        public delegate void SelectComfirmCamera(Form_SelectAccordCamera F, VideoCaptureDevice vcd);
        public event SelectComfirmCamera EventSelectComfirmCamera;
        private void Btn_Comfirm_Click(object sender, EventArgs e)
        {
            _VideoSource.VideoResolution = _VideoSource.VideoCapabilities[Cb_CameraResolution.SelectedIndex];
            EventSelectComfirmCamera(this, _VideoSource);
        }

        private void Cb_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCamera(Cb_Camera.SelectedIndex);
        }
    }
}
