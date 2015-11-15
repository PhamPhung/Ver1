using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoToan.DATA
{
    class ThongTinVanCo
    {
        private string ngchoi1;
        private string ngchoi2;

        private string filesave;

        public String NguoiChoi1
        {
            get { return ngchoi1; }
            set { ngchoi1 = value; }
        }
        public String NguoiChoi2
        {
            get { return ngchoi2; }
            set { ngchoi2 = value; }
        }
        public String FileSave
        {
            get { return filesave; }
            set { filesave = value; }
        }
    }
}
