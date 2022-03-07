
namespace BaserControlLibrary.WinForm
{
    partial class Form_SelectAccordCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Camera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_CameraResolution = new System.Windows.Forms.ComboBox();
            this.Btn_Comfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "摄像头";
            // 
            // Cb_Camera
            // 
            this.Cb_Camera.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_Camera.FormattingEnabled = true;
            this.Cb_Camera.Location = new System.Drawing.Point(16, 33);
            this.Cb_Camera.Name = "Cb_Camera";
            this.Cb_Camera.Size = new System.Drawing.Size(241, 29);
            this.Cb_Camera.TabIndex = 1;
            this.Cb_Camera.SelectedIndexChanged += new System.EventHandler(this.Cb_Camera_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "分辨率";
            // 
            // Cb_CameraResolution
            // 
            this.Cb_CameraResolution.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_CameraResolution.FormattingEnabled = true;
            this.Cb_CameraResolution.Location = new System.Drawing.Point(16, 102);
            this.Cb_CameraResolution.Name = "Cb_CameraResolution";
            this.Cb_CameraResolution.Size = new System.Drawing.Size(241, 29);
            this.Cb_CameraResolution.TabIndex = 1;
            // 
            // Btn_Comfirm
            // 
            this.Btn_Comfirm.AutoSize = true;
            this.Btn_Comfirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Comfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Comfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Comfirm.FlatAppearance.BorderSize = 2;
            this.Btn_Comfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Comfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Comfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Comfirm.Location = new System.Drawing.Point(0, 147);
            this.Btn_Comfirm.Name = "Btn_Comfirm";
            this.Btn_Comfirm.Size = new System.Drawing.Size(270, 39);
            this.Btn_Comfirm.TabIndex = 2;
            this.Btn_Comfirm.Text = "确定";
            this.Btn_Comfirm.UseVisualStyleBackColor = false;
            this.Btn_Comfirm.Click += new System.EventHandler(this.Btn_Comfirm_Click);
            // 
            // Form_SelectCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 186);
            this.Controls.Add(this.Btn_Comfirm);
            this.Controls.Add(this.Cb_CameraResolution);
            this.Controls.Add(this.Cb_Camera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SelectCamera";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择摄像头";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Camera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_CameraResolution;
        private System.Windows.Forms.Button Btn_Comfirm;
    }
}