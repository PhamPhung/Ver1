using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CoToan.CLASS;

namespace CoToan
{
    public partial class FormBanCo : Form
    {
        private int hang_QuanCoCu = 0;
        private int cot_QuanCoCu = 0;

        private int hang_QuanCoMoi = 0;
        private int cot_QuanCoMoi = 0;

        public static bool NguoiChoi1;
        public static bool NguoiChoi2;


        NGUOICHOI[] NguoiChoi = new NGUOICHOI[2];
        QUANCO[,] BanCo = new QUANCO[11, 9];

        QUANCO[] QuanAnCuaPheDo = new QUANCO[10];
        QUANCO[] QuanAnCuaPheXanh = new QUANCO[10];

        //lưu vị trí mà quân cờ hiện tại có thể ăn quân đối phương
        int[,] BanCoPhu = new int[11, 9];

        //lấy tên picturebox làm tên quân đang chọn
        QUANCO quanCoDangChon = new QUANCO();

        List<PictureBox> ds_pic = new List<PictureBox>();
        List<PictureBox> ds_picQuanAn = new List<PictureBox>();

        //phe : 0: do , 1 : xanh
        public static int pheDangDanh;
        //
        int time = 0;

        public FormBanCo()
        {
            InitializeComponent();
            this.NewGame();
            FormLuaChonCheDoChoi.mSocket.On("chat message", (data) =>
             {
                 BeginInvoke((Action)(() =>
                 {
                     this.lb_HienThiChat.Items.Add(data.ToString());
                 }), null);
             });
        }

        private void NewGame()
        {
            lTenDo.Text = FormLuaChonCheDoChoi.ten_NguoiChoi1;
            lTenXanh.Text = FormLuaChonCheDoChoi.ten_NguoiChoi2;

            for (int cot = 0; cot < 9; cot++)
            {
                for (int hang = 0; hang < 11; hang++)
                {
                    QUANCO quanco = new QUANCO();
                    quanco.Hang = hang;
                    quanco.Cot = cot;
                    if (hang == 10)
                    {
                        quanco.Phe = 0;
                        quanco.GiaTri = cot + 1;
                    }
                    else if (hang == 0)
                    {
                        quanco.Phe = 1;
                        int _giatri = 0;
                        switch (cot)
                        {
                            case 0: _giatri = 9; break;
                            case 1: _giatri = 8; break;
                            case 2: _giatri = 7; break;
                            case 3: _giatri = 6; break;
                            case 4: _giatri = 5; break;
                            case 5: _giatri = 4; break;
                            case 6: _giatri = 3; break;
                            case 7: _giatri = 2; break;
                            default: _giatri = 1; break;
                        }
                        quanco.GiaTri = _giatri;
                    }
                    else if (hang == 9 && cot == 4)
                    {
                        quanco.Phe = 0;
                        quanco.GiaTri = 0;
                    }
                    else if (hang == 1 && cot == 4)
                    {
                        quanco.Phe = 1;
                        quanco.GiaTri = 0;
                    }
                    else
                    {
                        quanco.Phe = 3;
                        quanco.GiaTri = -1;
                    }
                    BanCo[hang, cot] = quanco;
                    BanCo[hang, cot].Draw();
                    BanCo[hang, cot].picQuanCo.MouseClick += new MouseEventHandler(pic_MouseClick);
                    pBanCo.Controls.Add(BanCo[hang, cot].picQuanCo);
                }
                NguoiChoi[0] = new NGUOICHOI();
                NguoiChoi[0].KhoiTao(lTenDo.ToString(), 1);
                NguoiChoi[0].Draw(pQuanAnDuocDo);
            }
            HienThiLuot();
            time = 0;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void DuyetQuanAn(QUANCO _quanco)
        {
            //duyệt qua 8 ô xung quanh _quanco và tính toán
            List<QUANCO> ds_quanan = new List<QUANCO>();
            int _phe = _quanco.Phe;
            int _hang = _quanco.Hang;
            int _cot = _quanco.Cot;

            if (_hang + 1 < 11)
            {
                if (BanCo[_hang + 1, _cot].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang + 1, _cot], 1, 0));
            }
            if (_hang - 1 >= 0)
            {
                if (BanCo[_hang - 1, _cot].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang - 1, _cot], -1, 0));
            }
            if (_cot - 1 >= 0)
            {
                if (BanCo[_hang, _cot - 1].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang, _cot - 1], 0, -1));
            }
            if (_cot + 1 < 9)
            {
                if (BanCo[_hang, _cot + 1].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang, _cot + 1], 0, 1));
            }
            if (_cot - 1 >= 0 && _hang - 1 >= 0)
            {
                if (BanCo[_hang - 1, _cot - 1].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang - 1, _cot - 1], -1, -1));
            }
            if (_cot + 1 < 9 && _hang + 1 < 11)
            {
                if (BanCo[_hang + 1, _cot + 1].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang + 1, _cot + 1], 1, 1));
            }
            if (_cot - 1 >= 0 && _hang + 1 < 11)
            {
                if (BanCo[_hang + 1, _cot - 1].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang + 1, _cot - 1], 1, -1));
            }
            if (_cot + 1 < 9 && _hang - 1 >= 0)
            {
                if (BanCo[_hang - 1, _cot + 1].Phe == _phe) ds_quanan.InsertRange(ds_quanan.Count, TinhToan(_quanco, BanCo[_hang - 1, _cot + 1], -1, 1));
            }
            if (ds_quanan.Count > 0)
            {
                //duyệt từng phần tử để thay đổi trên giao diện và lấy danh sách tọa độ
                foreach (QUANCO q in ds_quanan)
                {
                    int h = q.picQuanCo.Location.Y;
                    int c = q.picQuanCo.Location.X;

                    //add picturebox ngay tại vị trí quân có thể ăn này
                    PictureBox pic = new PictureBox();
                    pic.Image = CoToan.Properties.Resources.CanEat;

                    pic.Width = 30;
                    pic.Height = 30;
                    pic.Location = new Point(10, 10);
                    //pic.BackColor = Color.Transparent;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.MouseClick += new MouseEventHandler(picQuanAn_MouseClick);
                    //pic.MouseClick += new MouseEventHandler(pic_MouseClick);
                    q.picQuanCo.Controls.Add(pic);
                    //q.picQuanCo.Visible = true;

                    BanCoPhu[q.Hang, q.Cot] = 1;
                    //pBanCo.Controls.Add(pic);
                    ds_picQuanAn.Add(pic);
                }
            }
        }

        private List<QUANCO> TinhToan(QUANCO _quancochinh, QUANCO _quancophu, int _valueH, int _valueC)
        {
            List<QUANCO> kq = new List<QUANCO>();

            int phe = _quancochinh.Phe;
            int phedoiphuong = 0;
            if (phe == 0) phedoiphuong = 1;
            int _hangc = _quancochinh.Hang;
            int _cotc = _quancochinh.Cot;

            int _hangp = _quancophu.Hang;
            int _cotp = _quancophu.Cot;

            int _gt1 = _quancochinh.GiaTri;
            int _gt2 = _quancophu.GiaTri;
            int cong = 0, tru = 0, nhan = 0, chia = 0;
            //tính toán theo hướng quân cờ chính --> quân cờ phụ
            //kết quả sẽ tính từ quân cờ phụ
            cong = (_gt1 + _gt2) % 10;

            if (_gt1 - _gt2 >= 0) { tru = (_gt1 - _gt2) % 10; }
            else { tru = (0 - (_gt1 - _gt2)) % 10; }

            nhan = (_gt1 * _gt2) % 10;
            //phép chia
            //nếu chia hết
            if (_gt2 != 0)
            {
                if (_gt1 % _gt2 == 0)
                {
                    chia = (_gt1 / _gt2);
                }
                //nếu chia dư thì lấy phần dư
                else
                {
                    chia = _gt1 % _gt2;
                }
            }
            else chia = 0;
            int max = TimMax(cong, tru, nhan, chia);
            if (max != 0)
            {
                int _h = _hangp + _valueH;
                int _c = _cotp + _valueC;
                for (int i = 1; i <= max; i++)
                {
                    _h += _valueH;
                    _c += _valueC;
                    if (_c >= 0 && _c < 9 && _h >= 0 && _h < 11)
                    {
                        int _phetemp = BanCo[_h, _c].Phe;
                        if (_phetemp == phedoiphuong)
                        {
                            if (i == cong || i == tru || i == nhan || i == chia)
                            {
                                kq.Add(BanCo[_h, _c]);
                                break;
                            }
                            else break;
                        }
                        else if (_phetemp == phe) break;
                    }
                    else break;
                }
            }
            //đổi vị trí 2 quân cờ trong phép tính
            //kết quả tính từ quân cờ chính
            cong = (_gt2 + _gt1) % 10;
            if (_gt2 - _gt1 >= 0) { tru = (_gt2 - _gt1) % 10; }
            else { tru = (0 - (_gt2 - _gt1)) % 10; }
            nhan = (_gt2 * _gt1) % 10;
            //phép chia
            //nếu chia hết
            if (_gt1 != 0)
            {
                if (_gt2 % _gt1 == 0)
                {
                    chia = (_gt2 / _gt1);
                }
                //nếu chia dư thì lấy phần dư
                else
                {
                    chia = _gt2 % _gt1;
                }
            }
            else chia = 0;
            max = TimMax(cong, tru, nhan, chia);
            if (max != 0)
            {
                int _h = _hangc + _valueH;
                int _c = _cotc + _valueC;
                for (int i = 1; i <= max; i++)
                {
                    _h += _valueH;
                    _c += _valueC;
                    if (_c >= 0 && _c < 9 && _h >= 0 && _h < 11)
                    {
                        int _phetemp = BanCo[_h, _c].Phe;
                        if (_phetemp == phedoiphuong)
                        {
                            if (i == cong || i == tru || i == nhan || i == chia)
                            {
                                kq.Add(BanCo[_h, _c]);
                                break;
                            }
                            else break;
                        }
                        else if (_phetemp == phe) break;
                    }
                    else break;
                }
            }
            return kq;
        }

        private void BatQuanCo(QUANCO _quanco, QUANCO _quancobian)
        {
            TinhDiem(_quancobian);
            //di chuyển quân cờ vào vị trí quân cờ bắt được
            int _hang1 = _quanco.Hang;
            int _cot1 = _quanco.Cot;

            int _hang2 = _quancobian.Hang;
            int _cot2 = _quancobian.Cot;

            BanCoPhu[_hang2, _cot2] = 0;

            BanCo[_hang1, _cot1].Move(BanCo[_hang2, _cot2]);
            //chuyển quân cờ vị trí cũ thành quân cờ trắng(ô trống)
            BanCo[_hang1, _cot1].Phe = 3;
            BanCo[_hang1, _cot1].GiaTri = -1;
            BanCo[_hang1, _cot1].picQuanCo.Image = CoToan.Properties.Resources.CanMove;
            BanCo[_hang1, _cot1].picQuanCo.Visible = false;
            //cập nhật lại BanCoPhu

        }

        //tính điểm cho bên ăn được quân đối phương
        private void TinhDiem(QUANCO _quanbian)
        {
            QUANCO q = new QUANCO();
            q = _quanbian;

            //ăn được quân 0 xử thắng tuyệt đối
            if (q.GiaTri == 0) { }
            else
            {
                int _diem = 0;
                //Quân đỏ
                _diem = NguoiChoi[pheDangDanh].Diem + q.GiaTri;
                NguoiChoi[pheDangDanh].Diem = _diem;
                NguoiChoi[pheDangDanh].QuanAnDuoc[q.GiaTri].picQuanCo.Visible = true;
                if (pheDangDanh == 0)
                {
                    lDiemDo.Text = "" + _diem;
                }
                else
                {
                    lDiemXanh.Text = "" + _diem;
                }
            }
        }

        //chiến thắng
        private void CheckWin()
        {

        }

        private void ResetQuanAn()
        {
            for (int h = 0; h < 11; h++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (BanCoPhu[h, c] == 1)
                    {
                        //reset
                        BanCo[h, c].picQuanCo.Controls.Clear();

                        //BanCo[h, c].picQuanCo.Visible = false;
                        BanCoPhu[h, c] = 0;
                    }
                }
            }

        }

        //tìm max của 4 phép tính
        private int TimMax(int a, int b, int c, int d)
        {
            int kq = a;
            if (b > kq) kq = b;
            if (c > kq) kq = c;
            if (d > kq) return d;
            else return kq;
        }

        //duyệt theo 8 hướng của 1 quân cờ và dựa trên biến visible để ẩn/hiện picturebox tương ứng
        private void Duyet8Huong(QUANCO _quanco, bool visible)
        {
            int so_quanco = _quanco.GiaTri;


            if (!visible)
            {
                foreach (PictureBox pic in ds_pic)
                {
                    pic.Visible = false;
                }
                ds_pic.Clear();
                so_quanco = 0;
            }

            if (so_quanco > 0)
            {
                int hang = _quanco.Hang;
                int cot = _quanco.Cot;
                int i = 1;
                //ngang phải
                for (i = 1; i <= so_quanco; i++)
                {
                    if (cot + i < 9)
                    {
                        if (BanCo[hang, cot + i].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang, cot + i].picQuanCo);
                            //BanCo[hang, c].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //ngang trái
                for (i = 1; i <= so_quanco; i++)
                {
                    if (cot - i >= 0)
                    {
                        if (BanCo[hang, cot - i].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang, cot - i].picQuanCo);
                            //BanCo[hang, c].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //dọc trên
                for (i = 1; i <= so_quanco; i++)
                {
                    if (hang - i >= 0)
                    {
                        if (BanCo[hang - i, cot].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang - i, cot].picQuanCo);
                            //BanCo[h, cot].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //dọc dưới
                for (i = 1; i <= so_quanco; i++)
                {
                    if (hang + i < 11)
                    {
                        if (BanCo[hang + i, cot].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang + i, cot].picQuanCo);
                            //BanCo[h, cot].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //chéo dưới phải
                for (i = 1; i <= so_quanco; i++)
                {
                    if ((hang + i < 11) && (cot + i < 9))
                    {
                        if (BanCo[hang + i, cot + i].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang + i, cot + i].picQuanCo);
                            //BanCo[h, c].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //chéo dưới trái
                for (i = 1; i <= so_quanco; i++)
                {
                    if ((hang + i < 11) && (cot - i >= 0))
                    {
                        if (BanCo[hang + i, cot - i].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang + i, cot - i].picQuanCo);
                            //BanCo[h, c].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //chéo trên phải
                for (i = 1; i <= so_quanco; i++)
                {
                    if ((hang - i >= 0) && (cot + i < 9))
                    {
                        if (BanCo[hang - i, cot + i].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang - i, cot + i].picQuanCo);
                            //BanCo[h, c].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //chéo trên trái
                for (i = 1; i <= so_quanco; i++)
                {
                    if ((hang - i >= 0) && (cot - i >= 0))
                    {
                        if (BanCo[hang - i, cot - i].Phe == 3)
                        {
                            ds_pic.Add(BanCo[hang - i, cot - i].picQuanCo);
                            //BanCo[h, c].picQuanCo.Visible = visible;
                        }
                        else break;
                    }
                    else break;
                }
                //
                foreach (PictureBox e in ds_pic) { e.Visible = visible; }
            }
        }

        //đổi 2 quân cờ
        private void ChangeQuanCo(QUANCO _quancoCu, QUANCO _quancoMoi)
        {
            this.hang_QuanCoCu = _quancoCu.Hang;
            this.cot_QuanCoCu = _quancoCu.Cot;

            this.hang_QuanCoMoi = _quancoMoi.Hang;
            this.cot_QuanCoMoi = _quancoMoi.Cot;

            BanCo[this.hang_QuanCoCu, this.cot_QuanCoCu].Move(BanCo[this.hang_QuanCoMoi, this.cot_QuanCoMoi]);
            BanCo[this.hang_QuanCoCu, this.cot_QuanCoCu].picQuanCo.Visible = false;
            BanCo[this.hang_QuanCoMoi, this.cot_QuanCoMoi].picQuanCo.Visible = true;
        }
        //
        private void HienThiLuot()
        {
            if (NguoiChoi1 == true)
            {
                picXanh.Image = CoToan.Properties.Resources.Xanh;
                picDo.Image = CoToan.Properties.Resources.Do_Select;
            }
            else
            {
                picXanh.Image = CoToan.Properties.Resources.Xanh_Select;
                picDo.Image = CoToan.Properties.Resources.Do;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time = time + 1;
            int h = time / 3600;
            int m = time / 60;
            int s = time % 60;
            string _h = h.ToString(), _m = m.ToString(), _s = s.ToString();
            if (h <= 9) { _h = "0" + h; }

            if (m <= 9) { _m = "0" + m; }
            if (s <= 9) { _s = "0" + s; }
            lTimer.Text = _h + ":" + _m + ":" + _s;
        }

        //click vào 1 picturebox trên bàn cờ (picturebox hiện)
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int _x = pic.Location.X / 50;
            int _y = pic.Location.Y / 50;
            //_y : hang
            //_x : cot

            QUANCO _quanco = new QUANCO();
            _quanco = BanCo[_y, _x];

            int _phe = _quanco.Phe;

            //quanCoDangChon.GiaTri==-1 <==> chưa có quân cờ nào được chọn
            if (quanCoDangChon.GiaTri == -1)
            {
                //nếu chọn 1 quân cờ cùng phe với phe của lượt hiện tại và chưa có quân cờ nào được chọn trên bàn cờ
                if (_phe == pheDangDanh)
                {
                    BanCo[_y, _x].ViewChange();
                    quanCoDangChon = _quanco;
                    Duyet8Huong(_quanco, true);
                    DuyetQuanAn(quanCoDangChon);
                }
            }
            //nếu người chơi đã chọn 1 quân cờ
            else
            {
                //_phe==3 <==> quân này có thể di chuyển quân cờ đang chọn vào
                if (_phe == 3)
                {
                    quanCoDangChon.ViewChange();
                    Duyet8Huong(quanCoDangChon, false);
                    //DuyetQuanAn(quanCoDangChon);
                    ChangeQuanCo(quanCoDangChon, _quanco);
                    if (pheDangDanh == 0)
                        pheDangDanh = 1;
                    else pheDangDanh = 0;
                    HienThiLuot();
                }
                //khi chọn 1 quân cờ khác cùng phe
                else if (_phe == pheDangDanh)
                {
                    //cùng giá trị (click lần 2 vào quân đang chọn)
                    if (quanCoDangChon.GiaTri == _quanco.GiaTri)
                    {
                        BanCo[_y, _x].ViewChange();
                        Duyet8Huong(quanCoDangChon, false);
                        ResetQuanAn();
                        //DuyetQuanAn(quanCoDangChon);
                        quanCoDangChon = new QUANCO();
                        quanCoDangChon.GiaTri = -1;
                    }
                    else
                    {
                        quanCoDangChon.ViewChange();
                        Duyet8Huong(quanCoDangChon, false);
                        ResetQuanAn();
                        quanCoDangChon = _quanco;
                        BanCo[_y, _x].ViewChange();
                        Duyet8Huong(_quanco, true);
                        DuyetQuanAn(quanCoDangChon);
                    }
                }
                //khi chọn ô trống hoặc quân cờ khác phe
                else
                {
                    if (BanCoPhu[_y, _x] != 1)
                    {
                        quanCoDangChon.ViewChange();
                        Duyet8Huong(quanCoDangChon, false);
                        ResetQuanAn();
                        quanCoDangChon = new QUANCO();
                        quanCoDangChon.GiaTri = -1;
                    }
                    //chọn vào quân cờ có thể bắt được
                    else
                    {
                        quanCoDangChon.ViewChange();
                        ResetQuanAn();
                        BatQuanCo(quanCoDangChon, _quanco);
                        Duyet8Huong(quanCoDangChon, false);
                        quanCoDangChon = new QUANCO();
                        quanCoDangChon.GiaTri = -1;
                        if (pheDangDanh == 0)
                            pheDangDanh = 1;
                        else pheDangDanh = 0;
                        HienThiLuot();
                    }
                }
            }
        }


        private void picQuanAn_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Control pic2 = pic.Parent;

            int h = pic2.Location.Y / 50;
            int c = pic2.Location.X / 50;

            QUANCO _quanco = new QUANCO();
            _quanco = BanCo[h, c];
            quanCoDangChon.ViewChange();
            ResetQuanAn();
            BatQuanCo(quanCoDangChon, _quanco);
            Duyet8Huong(quanCoDangChon, false);
            quanCoDangChon = new QUANCO();
            quanCoDangChon.GiaTri = -1;

            if (pheDangDanh == 0)
            {
                //pheDangDanh = 1;
                FormLuaChonCheDoChoi.mSocket.Emit("PheDuocDanh", "NguoiChoiThu2|" + this.hang_QuanCoCu + "|" + this.hang_QuanCoMoi + "|" + this.cot_QuanCoCu + "|" + this.cot_QuanCoMoi);
            }
            else
            {
                pheDangDanh = 0;
                FormLuaChonCheDoChoi.mSocket.Emit("PheDuocDanh", "NguoiChoiThu1| " + this.hang_QuanCoCu + "|" + this.hang_QuanCoMoi + "|" + this.cot_QuanCoCu + "|" + this.cot_QuanCoMoi);
            }

            HienThiLuot();
        }

        //
        //event của button setting
        //
        private void btSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiDong fluachonchedochoi = new FormKhoiDong();
            fluachonchedochoi.ShowDialog();
            this.Close();
        }

        private void btSetting_MouseEnter(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("IconSetting_Select");
        }

        private void btSetting_MouseLeave(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("IconSetting");
        }

        //
        //event của Menu
        //
        private void MenuThoat_Click(object sender, EventArgs e)
        {

        }

        private void btn_GuiTinNhan_Click(object sender, EventArgs e)
        {
            FormLuaChonCheDoChoi.mSocket.Emit("chat message", FormLuaChonCheDoChoi.ten_NguoiChoi1 + ": " + this.tb_Chat.Text);
            this.tb_Chat.Text = string.Empty;
        }
    }
}
