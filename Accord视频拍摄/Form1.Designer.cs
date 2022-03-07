namespace Accord视频拍摄
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSupportedModes = new System.Windows.Forms.ComboBox();
            this.comboBoxAttachedCameras = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSavedir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.停止录像 = new System.Windows.Forms.Button();
            this.开始录像 = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new Accord.Controls.VideoSourcePlayer();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.BtnStart);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.comboBoxSupportedModes);
            this.groupBox.Controls.Add(this.comboBoxAttachedCameras);
            this.groupBox.Location = new System.Drawing.Point(301, 12);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(267, 157);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(10, 122);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(84, 23);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "开启摄像头";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
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
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "選擇解析度";
            // 
            // comboBoxSupportedModes
            // 
            this.comboBoxSupportedModes.FormattingEnabled = true;
            this.comboBoxSupportedModes.Location = new System.Drawing.Point(8, 87);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 249);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 21);
            this.textBox1.TabIndex = 17;
            // 
            // BtnSavedir
            // 
            this.BtnSavedir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSavedir.Location = new System.Drawing.Point(363, 227);
            this.BtnSavedir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSavedir.Name = "BtnSavedir";
            this.BtnSavedir.Size = new System.Drawing.Size(63, 20);
            this.BtnSavedir.TabIndex = 16;
            this.BtnSavedir.Text = "选择";
            this.BtnSavedir.UseVisualStyleBackColor = true;
            this.BtnSavedir.Click += new System.EventHandler(this.BtnSavedir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "保存路径";
            // 
            // 停止录像
            // 
            this.停止录像.Location = new System.Drawing.Point(401, 186);
            this.停止录像.Name = "停止录像";
            this.停止录像.Size = new System.Drawing.Size(98, 32);
            this.停止录像.TabIndex = 13;
            this.停止录像.Text = "停止录像";
            this.停止录像.UseVisualStyleBackColor = true;
            this.停止录像.Click += new System.EventHandler(this.停止录像_Click);
            // 
            // 开始录像
            // 
            this.开始录像.Location = new System.Drawing.Point(297, 186);
            this.开始录像.Name = "开始录像";
            this.开始录像.Size = new System.Drawing.Size(98, 32);
            this.开始录像.TabIndex = 14;
            this.开始录像.Text = "开始录像";
            this.开始录像.UseVisualStyleBackColor = true;
            this.开始录像.Click += new System.EventHandler(this.开始录像_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(279, 310);
            this.videoSourcePlayer1.TabIndex = 18;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 334);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSavedir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.停止录像);
            this.Controls.Add(this.开始录像);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSupportedModes;
        private System.Windows.Forms.ComboBox comboBoxAttachedCameras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSavedir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button 停止录像;
        private System.Windows.Forms.Button 开始录像;
        private Accord.Controls.VideoSourcePlayer videoSourcePlayer1;
    }
}

