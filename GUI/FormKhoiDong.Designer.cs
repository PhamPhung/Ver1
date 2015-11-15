namespace CoToan
{
    partial class FormKhoiDong
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
            this.btQuit = new System.Windows.Forms.Button();
            this.btVanMoi = new System.Windows.Forms.Button();
            this.btChoiTiep = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(174, 156);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(104, 55);
            this.btQuit.TabIndex = 0;
            this.btQuit.Text = "Thoát";
            this.btQuit.UseVisualStyleBackColor = true;
            // 
            // btVanMoi
            // 
            this.btVanMoi.Location = new System.Drawing.Point(37, 12);
            this.btVanMoi.Name = "btVanMoi";
            this.btVanMoi.Size = new System.Drawing.Size(97, 50);
            this.btVanMoi.TabIndex = 1;
            this.btVanMoi.Text = "Ván Mới";
            this.btVanMoi.UseVisualStyleBackColor = true;
            this.btVanMoi.Click += new System.EventHandler(this.btVanMoi_Click);
            // 
            // btChoiTiep
            // 
            this.btChoiTiep.Location = new System.Drawing.Point(174, 12);
            this.btChoiTiep.Name = "btChoiTiep";
            this.btChoiTiep.Size = new System.Drawing.Size(104, 50);
            this.btChoiTiep.TabIndex = 2;
            this.btChoiTiep.Text = "Ván đã lưu";
            this.btChoiTiep.UseVisualStyleBackColor = true;
            this.btChoiTiep.Click += new System.EventHandler(this.btChoiTiep_Click);
            // 
            // btInfo
            // 
            this.btInfo.Location = new System.Drawing.Point(37, 84);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(97, 56);
            this.btInfo.TabIndex = 3;
            this.btInfo.Text = "Thông Tin";
            this.btInfo.UseVisualStyleBackColor = true;
            // 
            // FormKhoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btChoiTiep);
            this.Controls.Add(this.btVanMoi);
            this.Controls.Add(this.btQuit);
            this.Name = "FormKhoiDong";
            this.Text = "FormKhoiDong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btVanMoi;
        private System.Windows.Forms.Button btChoiTiep;
        private System.Windows.Forms.Button btInfo;
    }
}