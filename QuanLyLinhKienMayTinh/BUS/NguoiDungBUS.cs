using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static string _maNV;
        NguoiDung_func ndDAL = new NguoiDung_func();

        public bool KiemTraPass(string pass)
        {
            return ndDAL.KiemTraPass(pass);
        }

        public DataTable layMaManHinhVisible(string maNV)
        {
            return ndDAL.layMaManHinhVisible(maNV);    
        }

        public void updateNewPassword(string pass)
        {
            ndDAL.updateNewPassword(pass);
        }

        //bảng băm mã hóa password đăng nhập
        public string Hash(string password)
        {
            return ndDAL.Hash(password);
        }

        public bool KiemTraNguoiDung(NguoiDung user)
        {
            NguoiDung_func._maNV = _maNV;
            return ndDAL.KiemTraNguoiDung(user);
        }

        public int Check_config()
        {
           return ndDAL.Check_config();
        }

        public int KiemTraNguoiDungv2(NguoiDung user)
        {
            return ndDAL.KiemTraNguoiDungv2(user);
        }

        public bool ThemNguoiDung(NguoiDung nd)
        {
            return ndDAL.ThemNguoiDung(nd);
        }

        public void resetPassword(string _taikhoan)
        {
            ndDAL.resetPassword(_taikhoan);
        }

        public DataTable layMaNhomND(string maNV)
        {
            return ndDAL.layMaNhomND(maNV);
        }

        public DataTable layManHinhNhomND(int maNhomND)
        {
            return ndDAL.layManHinhNhomND(maNhomND);
        }

        public List<int> ListMaNhomND(string maNV)
        {
            return ndDAL.ListMaNhomND(maNV);
        }


        public DataTable layMaManHinhBiKhoa(int maNhomND)
        {
            return ndDAL.layMaManHinhBiKhoa(maNhomND);
        }
    }
}
