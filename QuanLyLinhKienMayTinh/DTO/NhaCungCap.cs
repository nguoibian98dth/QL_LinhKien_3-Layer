using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class NhaCungCap
    {
        string str_MaNCC, str_TenNCC, str_DiaChi, str_DienThoai, str_SoTaiKhoan;
        DateTime str_NgayDangKy;

        public string MaNCC
        {
            get { return str_MaNCC; }
            set { str_MaNCC = value; }
        }

        public string TenNCC
        {
            get { return str_TenNCC; }
            set { str_TenNCC = value; }
        }

        public string DiaChi
        {
            get { return str_DiaChi; }
            set { str_DiaChi = value; }
        }

        public string DienThoai
        {
            get { return str_DienThoai; }
            set { str_DienThoai = value; }
        }

        public string SoTaiKhoan
        {
            get { return str_SoTaiKhoan; }
            set { str_SoTaiKhoan = value; }
        }


        public DateTime NgayDangKy
        {
            get { return str_NgayDangKy; }
            set { str_NgayDangKy = value; }
        }

    }
}
