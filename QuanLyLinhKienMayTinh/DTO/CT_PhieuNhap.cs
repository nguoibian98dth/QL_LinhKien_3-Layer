using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_PhieuNhap
    {
        string str_MaCTPN, str_MaPN, str_MaLK, str_GhiChu;
        int str_SoLuong;

        public string MaCTPN
        {
            set { str_MaCTPN = value; }
            get { return str_MaCTPN; }

        }

        public string MaPN
        {
            set { str_MaPN = value; }
            get { return str_MaPN; }

        }

        public string MaLK
        {
            set { str_MaLK = value; }
            get { return str_MaLK; }
        }

        public int SoLuong
        {
            set { str_SoLuong = value; }
            get { return str_SoLuong; }

        }

        public string GhiChu
        {
            set { str_GhiChu = value; }
            get { return str_GhiChu; }
        }
    }
}
