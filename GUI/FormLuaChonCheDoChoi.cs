using System;
using System.Windows.Forms;
using CoToan.DATA;
using Quobject.SocketIoClientDotNet.Client;
using System.Diagnostics;

namespace CoToan
{
    public partial class FormLuaChonCheDoChoi : Form
    {
        public string LocalHost = "http://localhost:3000";
        public string Internet = "http://phamphung.cloudapp.net:3000";
        public static Socket mSocket;
        public static string ten_NguoiChoi1;
        public static string ten_NguoiChoi2;
        public static int mode;
        public static int pheMay = 0;
        private bool defaultMember = false;
        private bool checkConnect;

        public FormLuaChonCheDoChoi()
        {
            InitializeComponent();
        }

        public Boolean CheckThongTin()
        {
            if (!String.IsNullOrWhiteSpace(tb_TenNguoiChoi.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên người chơi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void connectInternet()
        {
            mSocket = IO.Socket(this.LocalHost);
            if (this.checkConnect == false)
            {
                this.checkConnect = true;
                mSocket.Connect();
            }

            mSocket.On(Socket.EVENT_CONNECT, () =>
            {
                BeginInvoke((Action)(() =>
                {
                    Debug.WriteLine("OK");
                    this.tb_StatusConnection.Text = "Kết nối thành công Internet.!";
                }), null);
            });

            mSocket.On(Socket.EVENT_DISCONNECT, () =>
            {
                BeginInvoke((Action)(() =>
                {
                    this.tb_StatusConnection.Text = "Ngắt kết nối.!";
                }), null);
            });

            mSocket.On("Doc danh sach phong choi", (data) =>
            {
                BeginInvoke((Action)(() =>
                {
                    string[] danhsachphong = data.ToString().Split('|');
                    this.lb_DanhSachPhong.Items.Clear();
                    foreach (var phong in danhsachphong)
                        if (!String.IsNullOrWhiteSpace(phong))
                            this.lb_DanhSachPhong.Items.Add(phong);
                }), null);
            });
        }

        private void rbInternetMode_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbInternetMode.Checked == true)
            {
                mode = 1;
                this.connectInternet();
                this.tb_TenNguoiChoi.Enabled = true;
                this.lb_DanhSachPhong.Visible = true;
            }
        }

        private void btn_TaoPhong_Click(object sender, EventArgs e)
        {
            if (this.CheckThongTin())
            {
                mSocket.Emit("BatDau", this.tb_TenNguoiChoi.Text);

                mSocket.On("OK", (data) =>
                {
                    BeginInvoke((Action)(() =>
                    {
                        if (data.ToString().Contains("NguoiChoiThu1"))
                        {
                            defaultMember = true;
                            mSocket.Emit("ThongTinVanCo", "NguoiChoiThu1");
                        }

                        if (data.ToString().Contains("Du2NguoiChoi"))
                        {
                            string[] members = data.ToString().Split('|');
                            if (defaultMember)
                            {
                                ten_NguoiChoi1 = members[1];
                                ten_NguoiChoi2 = members[2];
                                FormBanCo.NguoiChoi1 = true;
                                FormBanCo.NguoiChoi2 = false;
                            }
                            else
                            {
                                ten_NguoiChoi1 = members[2];
                                ten_NguoiChoi2 = members[1];
                            }
                            this.Hide();
                            new FormBanCo().ShowDialog();
                            this.Close();

                        }
                    }), null);
                });
            }
        }

        private void rbLanMode_CheckedChanged(object sender, EventArgs e)
        {
            this.lb_DanhSachPhong.Items.Clear();
        }
    }
}