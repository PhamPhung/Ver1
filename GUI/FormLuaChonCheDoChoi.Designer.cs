namespace CoToan
{
    partial class FormLuaChonCheDoChoi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tb_TenNguoiChoi = new System.Windows.Forms.TextBox();
            this.lb_TenNguoiChoi = new System.Windows.Forms.Label();
            this.gp_CheDoChoi = new System.Windows.Forms.GroupBox();
            this.btn_VaoPhong = new System.Windows.Forms.Button();
            this.btn_TaoPhong = new System.Windows.Forms.Button();
            this.rbInternetMode = new System.Windows.Forms.RadioButton();
            this.rbLanMode = new System.Windows.Forms.RadioButton();
            this.gp_ThongTinPhong = new System.Windows.Forms.GroupBox();
            this.lb_DanhSachPhong = new System.Windows.Forms.ListBox();
            this.tb_StatusConnection = new System.Windows.Forms.TextBox();
            this.gp_CheDoChoi.SuspendLayout();
            this.gp_ThongTinPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_TenNguoiChoi
            // 
            this.tb_TenNguoiChoi.Enabled = false;
            this.tb_TenNguoiChoi.Location = new System.Drawing.Point(52, 160);
            this.tb_TenNguoiChoi.Margin = new System.Windows.Forms.Padding(6);
            this.tb_TenNguoiChoi.MaxLength = 20;
            this.tb_TenNguoiChoi.Name = "tb_TenNguoiChoi";
            this.tb_TenNguoiChoi.Size = new System.Drawing.Size(382, 31);
            this.tb_TenNguoiChoi.TabIndex = 3;
            // 
            // lb_TenNguoiChoi
            // 
            this.lb_TenNguoiChoi.AutoSize = true;
            this.lb_TenNguoiChoi.Location = new System.Drawing.Point(12, 129);
            this.lb_TenNguoiChoi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_TenNguoiChoi.Name = "lb_TenNguoiChoi";
            this.lb_TenNguoiChoi.Size = new System.Drawing.Size(210, 25);
            this.lb_TenNguoiChoi.TabIndex = 5;
            this.lb_TenNguoiChoi.Text = "Nhập tên người chơi:";
            // 
            // gp_CheDoChoi
            // 
            this.gp_CheDoChoi.Controls.Add(this.btn_VaoPhong);
            this.gp_CheDoChoi.Controls.Add(this.btn_TaoPhong);
            this.gp_CheDoChoi.Controls.Add(this.tb_TenNguoiChoi);
            this.gp_CheDoChoi.Controls.Add(this.rbInternetMode);
            this.gp_CheDoChoi.Controls.Add(this.rbLanMode);
            this.gp_CheDoChoi.Controls.Add(this.lb_TenNguoiChoi);
            this.gp_CheDoChoi.Location = new System.Drawing.Point(24, 23);
            this.gp_CheDoChoi.Margin = new System.Windows.Forms.Padding(6);
            this.gp_CheDoChoi.Name = "gp_CheDoChoi";
            this.gp_CheDoChoi.Padding = new System.Windows.Forms.Padding(6);
            this.gp_CheDoChoi.Size = new System.Drawing.Size(446, 290);
            this.gp_CheDoChoi.TabIndex = 7;
            this.gp_CheDoChoi.TabStop = false;
            this.gp_CheDoChoi.Text = "Chế độ chơi :";
            // 
            // btn_VaoPhong
            // 
            this.btn_VaoPhong.Location = new System.Drawing.Point(228, 200);
            this.btn_VaoPhong.Name = "btn_VaoPhong";
            this.btn_VaoPhong.Size = new System.Drawing.Size(205, 75);
            this.btn_VaoPhong.TabIndex = 7;
            this.btn_VaoPhong.Text = "Vào Phòng";
            this.btn_VaoPhong.UseVisualStyleBackColor = true;
            // 
            // btn_TaoPhong
            // 
            this.btn_TaoPhong.Location = new System.Drawing.Point(17, 200);
            this.btn_TaoPhong.Name = "btn_TaoPhong";
            this.btn_TaoPhong.Size = new System.Drawing.Size(205, 75);
            this.btn_TaoPhong.TabIndex = 6;
            this.btn_TaoPhong.Text = "Tạo Phòng";
            this.btn_TaoPhong.UseVisualStyleBackColor = true;
            this.btn_TaoPhong.Click += new System.EventHandler(this.btn_TaoPhong_Click);
            // 
            // rbInternetMode
            // 
            this.rbInternetMode.AutoSize = true;
            this.rbInternetMode.Location = new System.Drawing.Point(52, 36);
            this.rbInternetMode.Margin = new System.Windows.Forms.Padding(6);
            this.rbInternetMode.Name = "rbInternetMode";
            this.rbInternetMode.Size = new System.Drawing.Size(188, 29);
            this.rbInternetMode.TabIndex = 2;
            this.rbInternetMode.Text = "Kết nối Internet";
            this.rbInternetMode.UseVisualStyleBackColor = true;
            this.rbInternetMode.CheckedChanged += new System.EventHandler(this.rbInternetMode_CheckedChanged);
            // 
            // rbLanMode
            // 
            this.rbLanMode.AutoSize = true;
            this.rbLanMode.Location = new System.Drawing.Point(52, 77);
            this.rbLanMode.Margin = new System.Windows.Forms.Padding(6);
            this.rbLanMode.Name = "rbLanMode";
            this.rbLanMode.Size = new System.Drawing.Size(211, 29);
            this.rbLanMode.TabIndex = 1;
            this.rbLanMode.Text = "Kết nối mạng Lan";
            this.rbLanMode.UseVisualStyleBackColor = true;
            this.rbLanMode.CheckedChanged += new System.EventHandler(this.rbLanMode_CheckedChanged);
            // 
            // gp_ThongTinPhong
            // 
            this.gp_ThongTinPhong.Controls.Add(this.lb_DanhSachPhong);
            this.gp_ThongTinPhong.Location = new System.Drawing.Point(482, 23);
            this.gp_ThongTinPhong.Margin = new System.Windows.Forms.Padding(6);
            this.gp_ThongTinPhong.Name = "gp_ThongTinPhong";
            this.gp_ThongTinPhong.Padding = new System.Windows.Forms.Padding(6);
            this.gp_ThongTinPhong.Size = new System.Drawing.Size(679, 564);
            this.gp_ThongTinPhong.TabIndex = 8;
            this.gp_ThongTinPhong.TabStop = false;
            this.gp_ThongTinPhong.Text = "Thông tin phòng:";
            // 
            // lb_DanhSachPhong
            // 
            this.lb_DanhSachPhong.ItemHeight = 25;
            this.lb_DanhSachPhong.Location = new System.Drawing.Point(9, 36);
            this.lb_DanhSachPhong.Name = "lb_DanhSachPhong";
            this.lb_DanhSachPhong.Size = new System.Drawing.Size(661, 504);
            this.lb_DanhSachPhong.TabIndex = 0;
            this.lb_DanhSachPhong.Visible = false;
            // 
            // tb_StatusConnection
            // 
            this.tb_StatusConnection.BackColor = System.Drawing.SystemColors.Control;
            this.tb_StatusConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_StatusConnection.Location = new System.Drawing.Point(13, 555);
            this.tb_StatusConnection.Name = "tb_StatusConnection";
            this.tb_StatusConnection.ReadOnly = true;
            this.tb_StatusConnection.Size = new System.Drawing.Size(251, 24);
            this.tb_StatusConnection.TabIndex = 9;
            this.tb_StatusConnection.Text = "Xin mời chọn kiểu kết nối.!";
            // 
            // FormLuaChonCheDoChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 602);
            this.Controls.Add(this.tb_StatusConnection);
            this.Controls.Add(this.gp_ThongTinPhong);
            this.Controls.Add(this.gp_CheDoChoi);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLuaChonCheDoChoi";
            this.Text = "FormLuaChonCheDoChoi";
            this.gp_CheDoChoi.ResumeLayout(false);
            this.gp_CheDoChoi.PerformLayout();
            this.gp_ThongTinPhong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_TenNguoiChoi;
        private System.Windows.Forms.Label lb_TenNguoiChoi;
        private System.Windows.Forms.GroupBox gp_CheDoChoi;
        private System.Windows.Forms.GroupBox gp_ThongTinPhong;
        private System.Windows.Forms.RadioButton rbInternetMode;
        private System.Windows.Forms.RadioButton rbLanMode;
        private System.Windows.Forms.Button btn_TaoPhong;
        private System.Windows.Forms.Button btn_VaoPhong;
        private System.Windows.Forms.ListBox lb_DanhSachPhong;
        private System.Windows.Forms.TextBox tb_StatusConnection;
    }
}