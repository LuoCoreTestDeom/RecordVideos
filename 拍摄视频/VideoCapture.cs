using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Accord.Video.FFMPEG;
using System.Threading;
using Accord.Video.DirectShow;

namespace 拍摄视频
{
    public class VideoCapture
    {
        public Int32 newFrame;     // 标识是否有未渲染的帧
        public TimeSpan lastRenderingTime;     // 上一次渲染时间
        public Rect relativeRect;        // 相对渲染区域
        public Rect bmp_relative_rect;          // 正在应用的相对渲染区域
        public System.Drawing.Rectangle bmp_absolute_rect;      // 正在应用的绝对渲染区域
        public Int32 frameWidth;       // 一帧的原始宽度
        public Int32 frameHeight;      // 一帧的原始高度
        public System.Drawing.Rectangle frameRect;     // 一帧的渲染区域
        public Int32 bmp_stride;       // 一行像素占多少字节
        public Int32 bmp_length;       // 一帧图像占多少字节
        public IntPtr bmp_backBuffer;  // WriteableBitmap的后台缓冲指针
        public VideoFileWriter videoFileWriter;    // 视频写入文件
        public String videoFile;                   // 正在写入的视频文件
        public Stopwatch stopwatch;    // 录像计时
        public Int64 spf;              // 一帧多少毫秒
        public UInt32 frameIndex;       // 当前帧
        public object recordLocker = new object();     // 录像同步锁 

        #region Properties

        public String Name { get; }

        public Size ImageSize => new Size(bmp_absolute_rect.Width, bmp_absolute_rect.Height);

        public Rect RenderRect => relativeRect;


        public Boolean IsRecording => videoFileWriter != null && videoFileWriter.IsOpen && stopwatch != null;

        public Action<ImageSource> ImageSourceChanged { get; set; }

        #endregion

        private WriteableBitmap _writeableBitmap;
        public WriteableBitmap writeableBitmap
        {
            get => this._writeableBitmap;
            set
            {
                if (this._writeableBitmap == value)
                    return;

                if (this._writeableBitmap == null)
                    CompositionTarget.Rendering += OnRender;
                else if (value == null)
                    CompositionTarget.Rendering -= OnRender;

                this._writeableBitmap = value;
                this.ImageSourceChanged?.Invoke(value);
            }
        }
        private void OnRender(Object sender, EventArgs e)
        {
            var curRenderingTime = ((RenderingEventArgs)e).RenderingTime;

            if (curRenderingTime == lastRenderingTime)
                return;

            lastRenderingTime = curRenderingTime;

            if (Interlocked.CompareExchange(ref newFrame, 0, 1) != 1)
                return;

            var bmp = this.writeableBitmap;
            bmp.Lock();
            bmp.AddDirtyRect(new Int32Rect(0, 0, bmp.PixelWidth, bmp.PixelHeight));
            bmp.Unlock();
        }
    }
}
