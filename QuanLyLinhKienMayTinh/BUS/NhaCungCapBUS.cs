using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCap_func nccDAL= new NhaCungCap_func();

        public bool ThemNCC(NhaCungCap ncc)
        {
            return nccDAL.ThemNhaCungCap(ncc);
        }

        public bool CapNhatNCC(NhaCungCap ncc)
        {
            return nccDAL.CapNhatNhaCungCap(ncc);
        }

        public bool XoaNCC(NhaCungCap ncc)
        {
            return nccDAL.XoaNhaCungCap(ncc);
        }    

        public bool KiemTraKhiThemNCC(string _tenMoi, string _diaChiMoi)
        {
            return nccDAL.KiemTraKhiThemNCC(_tenMoi,_diaChiMoi);
        }

        public bool KiemTraKhiCapNhatNCC(string _tenMoi, string _diaChiMoi, int _dongDangChon)
        {
            return nccDAL.KiemTraKhiCapNhatNCC(_tenMoi, _diaChiMoi, _dongDangChon);
        }

        public bool kiemtraTrungIdNCC(string maNCC)
        {
            return nccDAL.kiemtraTrungIdNCC(maNCC);
        }
    }
}
