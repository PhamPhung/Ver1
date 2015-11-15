using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoToan.CLASS
{
    class NGUOICHOI
    {
        public string Ten = "";
        public int Phe;
        public int Diem = 0;

        public QUANCO[] QuanAnDuoc = new QUANCO[11]; 

        public void KhoiTao(string t,int p) 
        {
            Ten = t;
            Phe = p;
            for (int i = 0; i < 11; i++) 
            {
                QuanAnDuoc[i] = new QUANCO();
            }
            if (p == 0) //quân đỏ
            {
                QuanAnDuoc[0].KhoiTao(0, 0, 0, 0);
                QuanAnDuoc[1].KhoiTao(0, 1, 1, 0);
                QuanAnDuoc[2].KhoiTao(0, 2, 2, 0);
                QuanAnDuoc[3].KhoiTao(0, 3, 3, 0);
                QuanAnDuoc[4].KhoiTao(1, 0, 4, 0);
                QuanAnDuoc[5].KhoiTao(1, 2, 5, 0);
                QuanAnDuoc[6].KhoiTao(1, 3, 6, 0);
                QuanAnDuoc[7].KhoiTao(1, 4, 7, 0);
                QuanAnDuoc[8].KhoiTao(2, 0, 8, 0);
                QuanAnDuoc[9].KhoiTao(2, 1, 9, 0);
            }
            else  //quân xanh
            {
                QuanAnDuoc[0].KhoiTao(0, 0, 0, 1);
                QuanAnDuoc[1].KhoiTao(0, 1, 1, 1);
                QuanAnDuoc[2].KhoiTao(0, 2, 2, 1);
                QuanAnDuoc[3].KhoiTao(0, 3, 3, 1);
                QuanAnDuoc[4].KhoiTao(1, 0, 4, 1);
                QuanAnDuoc[5].KhoiTao(1, 2, 5, 1);
                QuanAnDuoc[6].KhoiTao(1, 3, 6, 1);
                QuanAnDuoc[7].KhoiTao(1, 4, 7, 1);
                QuanAnDuoc[8].KhoiTao(2, 0, 8, 1);
                QuanAnDuoc[9].KhoiTao(2, 1, 9, 1);
            }
        }
        public void Draw(Panel p) 
        {
            for (int i = 0; i < 11; i++) 
            {
                QuanAnDuoc[i].Draw();
                QuanAnDuoc[i].picQuanCo.Visible = false;
                p.Controls.Add(QuanAnDuoc[i].picQuanCo);
            }
            
        }
    }
}
