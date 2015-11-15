using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoToan
{
    public partial class FormKhoiDong : Form
    {

        public static int mode = 0;

        public FormKhoiDong()
        {
            InitializeComponent();
        }

        private void btVanMoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            mode = 0;
            FormLuaChonCheDoChoi fchoosemode = new FormLuaChonCheDoChoi();
            fchoosemode.ShowDialog();
            this.Close();
        }

        private void btChoiTiep_Click(object sender, EventArgs e)
        {
            this.Hide();
            mode = 1;
            FormLuaChonCheDoChoi fchoosemode = new FormLuaChonCheDoChoi();
            fchoosemode.ShowDialog();
            this.Close();
        }
    }
}
