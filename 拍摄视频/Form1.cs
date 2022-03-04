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

namespace 拍摄视频
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoDevices; //摄像头设备
        private VideoCaptureDevice videoSource;   //视频的来源选择
        private VideoSourcePlayer videoSourcePlayer;  //AForge控制控件
        private VideoFileWriter writer;   //写入到视频
        private bool is_record_video = false;  //是否开始录像
    }
}
