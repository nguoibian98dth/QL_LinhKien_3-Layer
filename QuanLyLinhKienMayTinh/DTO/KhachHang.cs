using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        string str_MaKH, str_TenKH, str_DiaChi, str_DienThoai;

        public string MaKH
        {
            set { str_MaKH = value; }
            get { return str_MaKH; }
            
        }

        public string TenKH
        {
            set { str_TenKH = value; }
            get { return str_TenKH; }
            
        }

        public string DiaChi
        {
            set { str_DiaChi = value; }
            get { return str_DiaChi; }
            
        }

        public string DienThoai
        {
            set { str_DienThoai = value; }
            get { return str_DienThoai; }
            
        }
    }
}
