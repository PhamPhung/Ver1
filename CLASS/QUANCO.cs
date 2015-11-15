using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CoToan.CLASS
{
    class QUANCO
    {
        public string Ten;
        //vị trí trên bàn cờ
        public int Hang;
        public int Cot;
        //số trên quân cờ
        // -1 : quân cờ trống trên bàn cờ
        public int GiaTri;

        public bool isSelect = false;

        //phe của quân cờ : xanh hoặc đỏ
        // 0 : đỏ
        // 1 : xanh
        // 3 : ô trống
        // 4 : ô có thể di chuyển quân cờ vào
        // 5 : ô sẽ thay quân cờ mới vào
        public int Phe;
        //tên file ảnh
        public PictureBox picQuanCo = new PictureBox();

        public void KhoiTao(int _hang,int _cot, int _giatri, int _phe) 
        {
            isSelect = false;
            Hang = _hang;
            Cot = _cot;
            GiaTri = _giatri;
            Phe = _phe;
        }

        public void Draw() 
        {
            if (Phe == 0)
            {
                if (GiaTri == 0) picQuanCo.Image = CoToan.Properties.Resources.Do_0;
                else
                    if (GiaTri == 1) picQuanCo.Image = CoToan.Properties.Resources.Do_1;
                else
                    if (GiaTri == 2) picQuanCo.Image = CoToan.Properties.Resources.Do_2;
                else
                    if (GiaTri == 3) picQuanCo.Image = CoToan.Properties.Resources.Do_3;
                else
                    if (GiaTri == 4) picQuanCo.Image = CoToan.Properties.Resources.Do_4;
                else
                    if (GiaTri == 5) picQuanCo.Image = CoToan.Properties.Resources.Do_5;
                else
                    if (GiaTri == 6) picQuanCo.Image = CoToan.Properties.Resources.Do_6;
                else
                    if (GiaTri == 7) picQuanCo.Image = CoToan.Properties.Resources.Do_7;
                else
                    if (GiaTri == 8) picQuanCo.Image = CoToan.Properties.Resources.Do_8;
                else
                    picQuanCo.Image = CoToan.Properties.Resources.Do_9;
                picQuanCo.Visible = true;
                picQuanCo.Tag = "0";
            }
            else if (Phe == 1)
            {
                if (GiaTri == 0) picQuanCo.Image = CoToan.Properties.Resources.Xanh_0;
                else 
                    if (GiaTri == 1) picQuanCo.Image = CoToan.Properties.Resources.Xanh_1;
                else 
                    if (GiaTri == 2) picQuanCo.Image = CoToan.Properties.Resources.Xanh_2;
                else 
                    if (GiaTri == 3) picQuanCo.Image = CoToan.Properties.Resources.Xanh_3;
                else 
                    if (GiaTri == 4) picQuanCo.Image = CoToan.Properties.Resources.Xanh_4;
                else 
                    if (GiaTri == 5) picQuanCo.Image = CoToan.Properties.Resources.Xanh_5;
                else
                    if (GiaTri == 6) picQuanCo.Image = CoToan.Properties.Resources.Xanh_6;
                else 
                    if (GiaTri == 7) picQuanCo.Image = CoToan.Properties.Resources.Xanh_7;
                else 
                    if (GiaTri == 8) picQuanCo.Image = CoToan.Properties.Resources.Xanh_8;
                else picQuanCo.Image = CoToan.Properties.Resources.Xanh_9;
                picQuanCo.Visible = true;
                picQuanCo.Tag = "1";
            }
            else
            {
                picQuanCo.Image = CoToan.Properties.Resources.CanMove;
                picQuanCo.Visible = false;
            }
            picQuanCo.Name = Phe+":"+GiaTri;
            picQuanCo.Width = 50;
            picQuanCo.Height = 50;
            picQuanCo.Cursor = Cursors.Hand;

            picQuanCo.Top = Hang * 50;
            picQuanCo.Left = Cot * 50;
            picQuanCo.BackColor = Color.Transparent;
            picQuanCo.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        public void Move(QUANCO _quancoMoi) 
        {
            QUANCO _temp = new QUANCO();
            _temp.GiaTri = _quancoMoi.GiaTri;
            _temp.Phe = _quancoMoi.Phe;
            _temp.picQuanCo.Image = _quancoMoi.picQuanCo.Image;
            //_temp.Hang = _quancoMoi.Hang;
            //_temp.Cot = _quancoMoi.Cot;

            _quancoMoi.GiaTri = this.GiaTri;
            _quancoMoi.Phe = this.Phe;
            _quancoMoi.isSelect = false;
            _quancoMoi.picQuanCo.Image = this.picQuanCo.Image;
            //_quancoMoi.Hang = this.Hang;
            //_quancoMoi.Cot = this.Cot;
            //_quancoMoi.Select();

            this.GiaTri = _temp.GiaTri;
            this.Phe = _temp.Phe;
            this.isSelect = false;
            this.picQuanCo.Image = _temp.picQuanCo.Image;
            //this.Hang = _temp.Hang;
            //this.Cot = _temp.Cot;
            //this.Select();
        }

        public void ViewChange() 
        {
            isSelect = !isSelect;
            this.Select();
        }

        public void Select()
        {
            if (isSelect)
            {
                if (Phe == 0)
                {
                    if (GiaTri == 0) picQuanCo.Image = CoToan.Properties.Resources.Do_0_Select;
                    else if (GiaTri == 1) picQuanCo.Image = CoToan.Properties.Resources.Do_1_Select;
                    else if (GiaTri == 2) picQuanCo.Image = CoToan.Properties.Resources.Do_2_Select;
                    else if (GiaTri == 3) picQuanCo.Image = CoToan.Properties.Resources.Do_3_Select;
                    else if (GiaTri == 4) picQuanCo.Image = CoToan.Properties.Resources.Do_4_Select;
                    else if (GiaTri == 5) picQuanCo.Image = CoToan.Properties.Resources.Do_5_Select;
                    else if (GiaTri == 6) picQuanCo.Image = CoToan.Properties.Resources.Do_6_Select;
                    else if (GiaTri == 7) picQuanCo.Image = CoToan.Properties.Resources.Do_7_Select;
                    else if (GiaTri == 8) picQuanCo.Image = CoToan.Properties.Resources.Do_8_Select;
                    else picQuanCo.Image = CoToan.Properties.Resources.Do_9_Select;
                }
                else if (Phe == 1)
                {
                    if (GiaTri == 0) picQuanCo.Image = CoToan.Properties.Resources.Xanh_0_Select;
                    else if (GiaTri == 1) picQuanCo.Image = CoToan.Properties.Resources.Xanh_1_Select;
                    else if (GiaTri == 2) picQuanCo.Image = CoToan.Properties.Resources.Xanh_2_Select;
                    else if (GiaTri == 3) picQuanCo.Image = CoToan.Properties.Resources.Xanh_3_Select;
                    else if (GiaTri == 4) picQuanCo.Image = CoToan.Properties.Resources.Xanh_4_Select;
                    else if (GiaTri == 5) picQuanCo.Image = CoToan.Properties.Resources.Xanh_5_Select;
                    else if (GiaTri == 6) picQuanCo.Image = CoToan.Properties.Resources.Xanh_6_Select;
                    else if (GiaTri == 7) picQuanCo.Image = CoToan.Properties.Resources.Xanh_7_Select;
                    else if (GiaTri == 8) picQuanCo.Image = CoToan.Properties.Resources.Xanh_8_Select;
                    else picQuanCo.Image = CoToan.Properties.Resources.Xanh_9;
                }
            }
            else 
            {
                if (Phe == 0)
                {
                    if (GiaTri == 0) picQuanCo.Image = CoToan.Properties.Resources.Do_0;
                    else if (GiaTri == 1) picQuanCo.Image = CoToan.Properties.Resources.Do_1;
                    else if (GiaTri == 2) picQuanCo.Image = CoToan.Properties.Resources.Do_2;
                    else if (GiaTri == 3) picQuanCo.Image = CoToan.Properties.Resources.Do_3;
                    else if (GiaTri == 4) picQuanCo.Image = CoToan.Properties.Resources.Do_4;
                    else if (GiaTri == 5) picQuanCo.Image = CoToan.Properties.Resources.Do_5;
                    else if (GiaTri == 6) picQuanCo.Image = CoToan.Properties.Resources.Do_6;
                    else if (GiaTri == 7) picQuanCo.Image = CoToan.Properties.Resources.Do_7;
                    else if (GiaTri == 8) picQuanCo.Image = CoToan.Properties.Resources.Do_8;
                    else picQuanCo.Image = CoToan.Properties.Resources.Do_9;
                    picQuanCo.Visible = true;
                }
                else if (Phe == 1)
                {
                    if (GiaTri == 0) picQuanCo.Image = CoToan.Properties.Resources.Xanh_0;
                    else if (GiaTri == 1) picQuanCo.Image = CoToan.Properties.Resources.Xanh_1;
                    else if (GiaTri == 2) picQuanCo.Image = CoToan.Properties.Resources.Xanh_2;
                    else if (GiaTri == 3) picQuanCo.Image = CoToan.Properties.Resources.Xanh_3;
                    else if (GiaTri == 4) picQuanCo.Image = CoToan.Properties.Resources.Xanh_4;
                    else if (GiaTri == 5) picQuanCo.Image = CoToan.Properties.Resources.Xanh_5;
                    else if (GiaTri == 6) picQuanCo.Image = CoToan.Properties.Resources.Xanh_6;
                    else if (GiaTri == 7) picQuanCo.Image = CoToan.Properties.Resources.Xanh_7;
                    else if (GiaTri == 8) picQuanCo.Image = CoToan.Properties.Resources.Xanh_8;
                    else picQuanCo.Image = CoToan.Properties.Resources.Xanh_9;
                    picQuanCo.Visible = true;
                }
            }
        }
    }
}
