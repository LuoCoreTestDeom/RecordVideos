namespace Accord_OpenCV
{
    partial class Frm_AccordOpenCV
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_CameraResolution = new System.Windows.Forms.ComboBox();
            this.CB_Camera = new System.Windows.Forms.ComboBox();
            this.摄像头参数 = new System.Windows.Forms.Button();
            this.停止录像 = new System.Windows.Forms.Button();
            this.录像 = new System.Windows.Forms.Button();
            this.开启摄像头 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.videoSourcePlayer1 = new Accord.Controls.VideoSourcePlayer();
            this.SuspendLayout();
            // 
            // CB_CameraResolution
            // 
            this.CB_CameraResolution.FormattingEnabled = true;
            this.CB_CameraResolution.Location = new System.Drawing.Point(116, 66);
            this.CB_CameraResolution.Name = "CB_CameraResolution";
            this.CB_CameraResolution.Size = new System.Drawing.Size(239, 20);
            this.CB_CameraResolution.TabIndex = 9;
            // 
            // CB_Camera
            // 
            this.CB_Camera.FormattingEnabled = true;
            this.CB_Camera.Location = new System.Drawing.Point(116, 22);
            this.CB_Camera.Name = "CB_Camera";
            this.CB_Camera.Size = new System.Drawing.Size(239, 20);
            this.CB_Camera.TabIndex = 10;
            this.CB_Camera.SelectedIndexChanged += new System.EventHandler(this.CB_Camera_SelectedIndexChanged);
            // 
            // 摄像头参数
            // 
            this.摄像头参数.Location = new System.Drawing.Point(12, 56);
            this.摄像头参数.Name = "摄像头参数";
            this.摄像头参数.Size = new System.Drawing.Size(98, 38);
            this.摄像头参数.TabIndex = 5;
            this.摄像头参数.Text = "摄像头参数";
            this.摄像头参数.UseVisualStyleBackColor = true;
            this.摄像头参数.Click += new System.EventHandler(this.摄像头参数_Click);
            // 
            // 停止录像
            // 
            this.停止录像.Location = new System.Drawing.Point(529, 12);
            this.停止录像.Name = "停止录像";
            this.停止录像.Size = new System.Drawing.Size(98, 38);
            this.停止录像.TabIndex = 6;
            this.停止录像.Text = "停止录像";
            this.停止录像.UseVisualStyleBackColor = true;
            this.停止录像.Click += new System.EventHandler(this.停止录像_Click);
            // 
            // 录像
            // 
            this.录像.Location = new System.Drawing.Point(425, 12);
            this.录像.Name = "录像";
            this.录像.Size = new System.Drawing.Size(98, 38);
            this.录像.TabIndex = 7;
            this.录像.Text = "录像";
            this.录像.UseVisualStyleBackColor = true;
            this.录像.Click += new System.EventHandler(this.录像_Click);
            // 
            // 开启摄像头
            // 
            this.开启摄像头.Location = new System.Drawing.Point(12, 12);
            this.开启摄像头.Name = "开启摄像头";
            this.开启摄像头.Size = new System.Drawing.Size(98, 38);
            this.开启摄像头.TabIndex = 8;
            this.开启摄像头.Text = "开启摄像头";
            this.开启摄像头.UseVisualStyleBackColor = true;
            this.开启摄像头.Click += new System.EventHandler(this.开启摄像头_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "分辨率选择";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "摄像头";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 110);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(615, 293);
            this.videoSourcePlayer1.TabIndex = 12;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // Frm_AccordOpenCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 415);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_CameraResolution);
            this.Controls.Add(this.CB_Camera);
            this.Controls.Add(this.摄像头参数);
            this.Controls.Add(this.停止录像);
            this.Controls.Add(this.录像);
            this.Controls.Add(this.开启摄像头);
            this.Name = "Frm_AccordOpenCV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_AccordOpenCV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_CameraResolution;
        private System.Windows.Forms.ComboBox CB_Camera;
        private System.Windows.Forms.Button 摄像头参数;
        private System.Windows.Forms.Button 停止录像;
        private System.Windows.Forms.Button 录像;
        private System.Windows.Forms.Button 开启摄像头;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Accord.Controls.VideoSourcePlayer videoSourcePlayer1;
    }
}

