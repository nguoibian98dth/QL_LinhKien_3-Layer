using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class CT_HoaDonMua
    {
        private String maHD;
        public String MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private String maLK;
        public String MaLK
        {
            get { return maLK; }
            set { maLK = value; }
        }

        private String tenLK;
        public String TenLK
        {
            get { return tenLK; }
            set { tenLK = value; }
        }

        private String loaiLK;
        public String LoaiLK
        {
            get { return loaiLK; }
            set { loaiLK = value; }
        }

        private String nhaSX;
        public String NhaSX
        {
            get { return nhaSX; }
            set { nhaSX = value; }
        }

        private int? Soluong;
        public int? SoLuong
        {
            get { return Soluong; }
            set { Soluong = value; }
        }
    }
}
