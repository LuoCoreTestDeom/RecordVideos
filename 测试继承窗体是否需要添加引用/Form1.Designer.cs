namespace 测试继承窗体是否需要添加引用
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
            this.button1 = new System.Windows.Forms.Button();
            this.accord_Camera1 = new BaserControlLibrary.WinForm.Accord_Camera();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "弹框";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accord_Camera1
            // 
            this.accord_Camera1.Font = new System.Drawing.Font("黑体", 20F);
            this.accord_Camera1.Location = new System.Drawing.Point(220, 22);
            this.accord_Camera1.MyPhotoError = "没有找到摄像设备,请联系[瑞康]购买。";
            this.accord_Camera1.Name = "accord_Camera1";
            this.accord_Camera1.Size = new System.Drawing.Size(333, 264);
            this.accord_Camera1.TabIndex = 1;
            this.accord_Camera1.TabStop = false;
            this.accord_Camera1.Text = "accord_Camera1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 68);
            this.button2.TabIndex = 0;
            this.button2.Text = "开启摄像头";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 296);
            this.Controls.Add(this.accord_Camera1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BaserControlLibrary.WinForm.Accord_Camera accord_Camera1;
        private System.Windows.Forms.Button button2;
    }
}

