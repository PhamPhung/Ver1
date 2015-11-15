using System.Windows.Forms;

namespace CoToan
{
    partial class FormBanCo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanCo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lDiemXanh = new System.Windows.Forms.Label();
            this.pQuanAnDuocXanh = new System.Windows.Forms.Panel();
            this.lTenXanh = new System.Windows.Forms.Label();
            this.lTileNameBlue = new System.Windows.Forms.Label();
            this.lScoreBlue = new System.Windows.Forms.Label();
            this.pRedInfo = new System.Windows.Forms.Panel();
            this.lDiemDo = new System.Windows.Forms.Label();
            this.pQuanAnDuocDo = new System.Windows.Forms.Panel();
            this.lTenDo = new System.Windows.Forms.Label();
            this.lTileNameRed = new System.Windows.Forms.Label();
            this.lScoreRed = new System.Windows.Forms.Label();
            this.pBanCo = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lTimer = new System.Windows.Forms.Label();
            this.picDo = new System.Windows.Forms.PictureBox();
            this.picXanh = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btSetting = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.tròChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vánMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiTrên1MáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtNốiMạngLanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtNốiInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mởVánCờĐãLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuVánCờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cờToánViệtNamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luậtChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómThựcHiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_GuiTinNhan = new System.Windows.Forms.Button();
            this.tb_Chat = new System.Windows.Forms.TextBox();
            this.lb_HienThiChat = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.pRedInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSetting)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CoToan.Properties.Resources.info_player;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lDiemXanh);
            this.panel1.Controls.Add(this.pQuanAnDuocXanh);
            this.panel1.Controls.Add(this.lTenXanh);
            this.panel1.Controls.Add(this.lTileNameBlue);
            this.panel1.Controls.Add(this.lScoreBlue);
            this.panel1.Location = new System.Drawing.Point(970, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 429);
            this.panel1.TabIndex = 6;
            // 
            // lDiemXanh
            // 
            this.lDiemXanh.AutoSize = true;
            this.lDiemXanh.BackColor = System.Drawing.Color.Transparent;
            this.lDiemXanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiemXanh.ForeColor = System.Drawing.Color.Blue;
            this.lDiemXanh.Location = new System.Drawing.Point(138, 62);
            this.lDiemXanh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lDiemXanh.Name = "lDiemXanh";
            this.lDiemXanh.Size = new System.Drawing.Size(31, 36);
            this.lDiemXanh.TabIndex = 5;
            this.lDiemXanh.Text = "0";
            // 
            // pQuanAnDuocXanh
            // 
            this.pQuanAnDuocXanh.BackColor = System.Drawing.Color.Transparent;
            this.pQuanAnDuocXanh.Location = new System.Drawing.Point(52, 119);
            this.pQuanAnDuocXanh.Margin = new System.Windows.Forms.Padding(6);
            this.pQuanAnDuocXanh.Name = "pQuanAnDuocXanh";
            this.pQuanAnDuocXanh.Size = new System.Drawing.Size(400, 288);
            this.pQuanAnDuocXanh.TabIndex = 4;
            // 
            // lTenXanh
            // 
            this.lTenXanh.BackColor = System.Drawing.Color.Transparent;
            this.lTenXanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenXanh.ForeColor = System.Drawing.Color.Blue;
            this.lTenXanh.Location = new System.Drawing.Point(216, 25);
            this.lTenXanh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTenXanh.Name = "lTenXanh";
            this.lTenXanh.Size = new System.Drawing.Size(256, 37);
            this.lTenXanh.TabIndex = 3;
            // 
            // lTileNameBlue
            // 
            this.lTileNameBlue.AutoSize = true;
            this.lTileNameBlue.BackColor = System.Drawing.Color.Transparent;
            this.lTileNameBlue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTileNameBlue.ForeColor = System.Drawing.Color.Blue;
            this.lTileNameBlue.Location = new System.Drawing.Point(28, 25);
            this.lTileNameBlue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTileNameBlue.Name = "lTileNameBlue";
            this.lTileNameBlue.Size = new System.Drawing.Size(185, 36);
            this.lTileNameBlue.TabIndex = 2;
            this.lTileNameBlue.Text = "Đối Phương: ";
            // 
            // lScoreBlue
            // 
            this.lScoreBlue.AutoSize = true;
            this.lScoreBlue.BackColor = System.Drawing.Color.Transparent;
            this.lScoreBlue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreBlue.ForeColor = System.Drawing.Color.Blue;
            this.lScoreBlue.Location = new System.Drawing.Point(30, 62);
            this.lScoreBlue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lScoreBlue.Name = "lScoreBlue";
            this.lScoreBlue.Size = new System.Drawing.Size(101, 36);
            this.lScoreBlue.TabIndex = 1;
            this.lScoreBlue.Text = "Điểm :";
            // 
            // pRedInfo
            // 
            this.pRedInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pRedInfo.BackgroundImage")));
            this.pRedInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pRedInfo.Controls.Add(this.lDiemDo);
            this.pRedInfo.Controls.Add(this.pQuanAnDuocDo);
            this.pRedInfo.Controls.Add(this.lTenDo);
            this.pRedInfo.Controls.Add(this.lTileNameRed);
            this.pRedInfo.Controls.Add(this.lScoreRed);
            this.pRedInfo.Location = new System.Drawing.Point(970, 766);
            this.pRedInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pRedInfo.Name = "pRedInfo";
            this.pRedInfo.Size = new System.Drawing.Size(492, 429);
            this.pRedInfo.TabIndex = 5;
            // 
            // lDiemDo
            // 
            this.lDiemDo.AutoSize = true;
            this.lDiemDo.BackColor = System.Drawing.Color.Transparent;
            this.lDiemDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiemDo.ForeColor = System.Drawing.Color.Red;
            this.lDiemDo.Location = new System.Drawing.Point(138, 62);
            this.lDiemDo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lDiemDo.Name = "lDiemDo";
            this.lDiemDo.Size = new System.Drawing.Size(31, 36);
            this.lDiemDo.TabIndex = 5;
            this.lDiemDo.Text = "0";
            // 
            // pQuanAnDuocDo
            // 
            this.pQuanAnDuocDo.BackColor = System.Drawing.Color.Transparent;
            this.pQuanAnDuocDo.Location = new System.Drawing.Point(52, 123);
            this.pQuanAnDuocDo.Margin = new System.Windows.Forms.Padding(6);
            this.pQuanAnDuocDo.Name = "pQuanAnDuocDo";
            this.pQuanAnDuocDo.Size = new System.Drawing.Size(400, 288);
            this.pQuanAnDuocDo.TabIndex = 4;
            // 
            // lTenDo
            // 
            this.lTenDo.BackColor = System.Drawing.Color.Transparent;
            this.lTenDo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenDo.ForeColor = System.Drawing.Color.Red;
            this.lTenDo.Location = new System.Drawing.Point(216, 25);
            this.lTenDo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTenDo.Name = "lTenDo";
            this.lTenDo.Size = new System.Drawing.Size(256, 37);
            this.lTenDo.TabIndex = 3;
            // 
            // lTileNameRed
            // 
            this.lTileNameRed.AutoSize = true;
            this.lTileNameRed.BackColor = System.Drawing.Color.Transparent;
            this.lTileNameRed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTileNameRed.ForeColor = System.Drawing.Color.Red;
            this.lTileNameRed.Location = new System.Drawing.Point(28, 25);
            this.lTileNameRed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTileNameRed.Name = "lTileNameRed";
            this.lTileNameRed.Size = new System.Drawing.Size(82, 36);
            this.lTileNameRed.TabIndex = 2;
            this.lTileNameRed.Text = "Bạn: ";
            // 
            // lScoreRed
            // 
            this.lScoreRed.AutoSize = true;
            this.lScoreRed.BackColor = System.Drawing.Color.Transparent;
            this.lScoreRed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreRed.ForeColor = System.Drawing.Color.Red;
            this.lScoreRed.Location = new System.Drawing.Point(30, 62);
            this.lScoreRed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lScoreRed.Name = "lScoreRed";
            this.lScoreRed.Size = new System.Drawing.Size(101, 36);
            this.lScoreRed.TabIndex = 1;
            this.lScoreRed.Text = "Điểm :";
            // 
            // pBanCo
            // 
            this.pBanCo.BackColor = System.Drawing.Color.Black;
            this.pBanCo.BackgroundImage = global::CoToan.Properties.Resources.BanCo;
            this.pBanCo.Location = new System.Drawing.Point(10, 10);
            this.pBanCo.Margin = new System.Windows.Forms.Padding(6);
            this.pBanCo.Name = "pBanCo";
            this.pBanCo.Size = new System.Drawing.Size(900, 1058);
            this.pBanCo.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời gian:";
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimer.ForeColor = System.Drawing.Color.Transparent;
            this.lTimer.Location = new System.Drawing.Point(212, 0);
            this.lTimer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(98, 37);
            this.lTimer.TabIndex = 10;
            this.lTimer.Text = "00:00";
            // 
            // picDo
            // 
            this.picDo.BackColor = System.Drawing.Color.Transparent;
            this.picDo.Image = global::CoToan.Properties.Resources.Do;
            this.picDo.Location = new System.Drawing.Point(238, 67);
            this.picDo.Margin = new System.Windows.Forms.Padding(6);
            this.picDo.Name = "picDo";
            this.picDo.Size = new System.Drawing.Size(100, 96);
            this.picDo.TabIndex = 11;
            this.picDo.TabStop = false;
            // 
            // picXanh
            // 
            this.picXanh.BackColor = System.Drawing.Color.Transparent;
            this.picXanh.Image = global::CoToan.Properties.Resources.Xanh;
            this.picXanh.Location = new System.Drawing.Point(382, 69);
            this.picXanh.Margin = new System.Windows.Forms.Padding(6);
            this.picXanh.Name = "picXanh";
            this.picXanh.Size = new System.Drawing.Size(100, 96);
            this.picXanh.TabIndex = 12;
            this.picXanh.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.picDo);
            this.panel2.Controls.Add(this.btSetting);
            this.panel2.Controls.Add(this.lTimer);
            this.panel2.Controls.Add(this.picXanh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(970, 563);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 175);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lượt của quân :";
            // 
            // btSetting
            // 
            this.btSetting.Image = global::CoToan.Properties.Resources.IconSetting;
            this.btSetting.Location = new System.Drawing.Point(418, 0);
            this.btSetting.Margin = new System.Windows.Forms.Padding(6);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(60, 58);
            this.btSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSetting.TabIndex = 8;
            this.btSetting.TabStop = false;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            this.btSetting.MouseEnter += new System.EventHandler(this.btSetting_MouseEnter);
            this.btSetting.MouseLeave += new System.EventHandler(this.btSetting_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(542, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 61);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cờ Toán Việt Nam";
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tròChơiToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.Menu.Size = new System.Drawing.Size(2001, 44);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "menuStrip1";
            // 
            // tròChơiToolStripMenuItem
            // 
            this.tròChơiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vánMớiToolStripMenuItem,
            this.toolStripSeparator1,
            this.mởVánCờĐãLưuToolStripMenuItem,
            this.lưuVánCờToolStripMenuItem,
            this.toolStripSeparator3,
            this.thoátToolStripMenuItem,
            this.toolStripSeparator2,
            this.MenuThoat});
            this.tròChơiToolStripMenuItem.Name = "tròChơiToolStripMenuItem";
            this.tròChơiToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.tròChơiToolStripMenuItem.Text = "Trò Chơi";
            // 
            // vánMớiToolStripMenuItem
            // 
            this.vánMớiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiTrên1MáyToolStripMenuItem,
            this.kếtNốiMạngLanToolStripMenuItem,
            this.kếtNốiInternetToolStripMenuItem});
            this.vánMớiToolStripMenuItem.Name = "vánMớiToolStripMenuItem";
            this.vánMớiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.vánMớiToolStripMenuItem.Size = new System.Drawing.Size(401, 38);
            this.vánMớiToolStripMenuItem.Text = "Ván Mới";
            // 
            // ngườiTrên1MáyToolStripMenuItem
            // 
            this.ngườiTrên1MáyToolStripMenuItem.Name = "ngườiTrên1MáyToolStripMenuItem";
            this.ngườiTrên1MáyToolStripMenuItem.Size = new System.Drawing.Size(327, 38);
            this.ngườiTrên1MáyToolStripMenuItem.Text = "2 Người Trên 1 Máy";
            // 
            // kếtNốiMạngLanToolStripMenuItem
            // 
            this.kếtNốiMạngLanToolStripMenuItem.Name = "kếtNốiMạngLanToolStripMenuItem";
            this.kếtNốiMạngLanToolStripMenuItem.Size = new System.Drawing.Size(327, 38);
            this.kếtNốiMạngLanToolStripMenuItem.Text = "Kết Nối Mạng Lan";
            // 
            // kếtNốiInternetToolStripMenuItem
            // 
            this.kếtNốiInternetToolStripMenuItem.Name = "kếtNốiInternetToolStripMenuItem";
            this.kếtNốiInternetToolStripMenuItem.Size = new System.Drawing.Size(327, 38);
            this.kếtNốiInternetToolStripMenuItem.Text = "Kết Nối Internet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(398, 6);
            // 
            // mởVánCờĐãLưuToolStripMenuItem
            // 
            this.mởVánCờĐãLưuToolStripMenuItem.Name = "mởVánCờĐãLưuToolStripMenuItem";
            this.mởVánCờĐãLưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mởVánCờĐãLưuToolStripMenuItem.Size = new System.Drawing.Size(401, 38);
            this.mởVánCờĐãLưuToolStripMenuItem.Text = "Mở Ván Cờ Đã Lưu";
            // 
            // lưuVánCờToolStripMenuItem
            // 
            this.lưuVánCờToolStripMenuItem.Name = "lưuVánCờToolStripMenuItem";
            this.lưuVánCờToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuVánCờToolStripMenuItem.Size = new System.Drawing.Size(401, 38);
            this.lưuVánCờToolStripMenuItem.Text = "Lưu Ván Cờ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(398, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(401, 38);
            this.thoátToolStripMenuItem.Text = "Tùy Chọn";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(398, 6);
            // 
            // MenuThoat
            // 
            this.MenuThoat.Name = "MenuThoat";
            this.MenuThoat.Size = new System.Drawing.Size(401, 38);
            this.MenuThoat.Text = "Thoát";
            this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cờToánViệtNamToolStripMenuItem,
            this.luậtChơiToolStripMenuItem,
            this.nhómThựcHiệnToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            // 
            // cờToánViệtNamToolStripMenuItem
            // 
            this.cờToánViệtNamToolStripMenuItem.Name = "cờToánViệtNamToolStripMenuItem";
            this.cờToánViệtNamToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.cờToánViệtNamToolStripMenuItem.Text = "Cờ Toán Việt Nam";
            // 
            // luậtChơiToolStripMenuItem
            // 
            this.luậtChơiToolStripMenuItem.Name = "luậtChơiToolStripMenuItem";
            this.luậtChơiToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.luậtChơiToolStripMenuItem.Text = "Luật Chơi";
            // 
            // nhómThựcHiệnToolStripMenuItem
            // 
            this.nhómThựcHiệnToolStripMenuItem.Name = "nhómThựcHiệnToolStripMenuItem";
            this.nhómThựcHiệnToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.nhómThựcHiệnToolStripMenuItem.Text = "Nhóm Thực Hiện";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pBanCo);
            this.panel3.Location = new System.Drawing.Point(20, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 1083);
            this.panel3.TabIndex = 9;
            // 
            // btn_GuiTinNhan
            // 
            this.btn_GuiTinNhan.Location = new System.Drawing.Point(1905, 1160);
            this.btn_GuiTinNhan.Name = "btn_GuiTinNhan";
            this.btn_GuiTinNhan.Size = new System.Drawing.Size(84, 35);
            this.btn_GuiTinNhan.TabIndex = 11;
            this.btn_GuiTinNhan.Text = "Gửi";
            this.btn_GuiTinNhan.UseVisualStyleBackColor = true;
            this.btn_GuiTinNhan.Click += new System.EventHandler(this.btn_GuiTinNhan_Click);
            // 
            // tb_Chat
            // 
            this.tb_Chat.Location = new System.Drawing.Point(1465, 1164);
            this.tb_Chat.Name = "tb_Chat";
            this.tb_Chat.Size = new System.Drawing.Size(434, 31);
            this.tb_Chat.TabIndex = 12;
            // 
            // lb_HienThiChat
            // 
            this.lb_HienThiChat.FormattingEnabled = true;
            this.lb_HienThiChat.ItemHeight = 25;
            this.lb_HienThiChat.Location = new System.Drawing.Point(1465, 112);
            this.lb_HienThiChat.Name = "lb_HienThiChat";
            this.lb_HienThiChat.Size = new System.Drawing.Size(524, 1029);
            this.lb_HienThiChat.TabIndex = 13;
            // 
            // FormBanCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(2001, 1229);
            this.Controls.Add(this.lb_HienThiChat);
            this.Controls.Add(this.tb_Chat);
            this.Controls.Add(this.btn_GuiTinNhan);
            this.Controls.Add(this.pRedInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormBanCo";
            this.Text = "Cờ Toán Việt Nam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pRedInfo.ResumeLayout(false);
            this.pRedInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSetting)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBanCo;
        private System.Windows.Forms.Label lScoreRed;
        private System.Windows.Forms.Label lTileNameRed;
        private System.Windows.Forms.Panel pRedInfo;
        private System.Windows.Forms.Label lTenDo;
        private System.Windows.Forms.Panel pQuanAnDuocDo;
        private System.Windows.Forms.Label lDiemDo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lDiemXanh;
        private System.Windows.Forms.Panel pQuanAnDuocXanh;
        private System.Windows.Forms.Label lTenXanh;
        private System.Windows.Forms.Label lTileNameBlue;
        private System.Windows.Forms.Label lScoreBlue;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.PictureBox picDo;
        private System.Windows.Forms.PictureBox picXanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem tròChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vánMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cờToánViệtNamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luậtChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómThựcHiệnToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem ngườiTrên1MáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtNốiMạngLanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtNốiInternetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mởVánCờĐãLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuVánCờToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
        private System.Windows.Forms.Button btn_GuiTinNhan;
        private System.Windows.Forms.TextBox tb_Chat;
        private System.Windows.Forms.ListBox lb_HienThiChat;
    }
}

