using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video;
using Accord.Video.DirectShow;
using AForge.Controls;

namespace Accord.雅阁
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices; //摄像头设备
        private VideoCaptureDevice videoSource;   //视频的来源选择
        public Form1()
        {
            InitializeComponent();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in videoDevices)
            {
                comboBoxAttachedCameras.Items.Add(VideoCaptureDevice.Name);
            }
        }

        private void Btn_StartVideo_Click(object sender, EventArgs e)
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
            if (Btn_StartVideo.Enabled)
            {
                videoSource.VideoResolution = videoSource.VideoCapabilities[comboBoxSupportedModes.SelectedIndex];
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                //videoSourcePlayer1.VideoSource =(IVideoSource) videoSource;
                //videoSourcePlayer1.Start();
                Btn_StartVideo.Enabled = false;
                comboBoxAttachedCameras.Enabled = false;
                comboBoxSupportedModes.Enabled = false;

            }
        }

        private void VideoSource_NewFrame(object sender, Video.NewFrameEventArgs eventArgs)
        {
           
            Task.Run(() =>
            {
                Bitmap bitmap = null;
                try
                {
                    pictureBox1.BeginInvoke(new EventHandler(delegate
                    {
                        try
                        {
                            pictureBox1.Image = eventArgs.Frame;
                        }
                        catch (Exception)
                        {

                            
                        }
                       

                    }));
                    //bitmap = DeepClone(eventArgs.Frame);    //获取到一帧图像
                }
                catch (Exception)
                {
                    bitmap = null;
                }
                if (bitmap != null) 
                {
                    
                }
                    
                
            });

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
    }
}
