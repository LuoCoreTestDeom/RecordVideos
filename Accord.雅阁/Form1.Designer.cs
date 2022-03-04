namespace Accord.雅阁
{
    partial class Form1
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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Btn_StartVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSupportedModes = new System.Windows.Forms.ComboBox();
            this.comboBoxAttachedCameras = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(218, 97);
            this.videoSourcePlayer1.TabIndex = 2;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Btn_StartVideo);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.comboBoxSupportedModes);
            this.groupBox.Controls.Add(this.comboBoxAttachedCameras);
            this.groupBox.Location = new System.Drawing.Point(310, 12);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(267, 132);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            // 
            // Btn_StartVideo
            // 
            this.Btn_StartVideo.Location = new System.Drawing.Point(8, 101);
            this.Btn_StartVideo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_StartVideo.Name = "Btn_StartVideo";
            this.Btn_StartVideo.Size = new System.Drawing.Size(84, 23);
            this.Btn_StartVideo.TabIndex = 10;
            this.Btn_StartVideo.Text = "开启摄像头";
            this.Btn_StartVideo.UseVisualStyleBackColor = true;
            this.Btn_StartVideo.Click += new System.EventHandler(this.Btn_StartVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择摄像头";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "分辨率";
            // 
            // comboBoxSupportedModes
            // 
            this.comboBoxSupportedModes.FormattingEnabled = true;
            this.comboBoxSupportedModes.Location = new System.Drawing.Point(7, 77);
            this.comboBoxSupportedModes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSupportedModes.Name = "comboBoxSupportedModes";
            this.comboBoxSupportedModes.Size = new System.Drawing.Size(255, 20);
            this.comboBoxSupportedModes.TabIndex = 3;
            // 
            // comboBoxAttachedCameras
            // 
            this.comboBoxAttachedCameras.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.comboBoxAttachedCameras.FormattingEnabled = true;
            this.comboBoxAttachedCameras.Location = new System.Drawing.Point(8, 29);
            this.comboBoxAttachedCameras.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAttachedCameras.Name = "comboBoxAttachedCameras";
            this.comboBoxAttachedCameras.Size = new System.Drawing.Size(255, 20);
            this.comboBoxAttachedCameras.TabIndex = 0;
            this.comboBoxAttachedCameras.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttachedCameras_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 208);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Btn_StartVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSupportedModes;
        private System.Windows.Forms.ComboBox comboBoxAttachedCameras;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

