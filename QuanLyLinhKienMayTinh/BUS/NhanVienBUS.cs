using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVien_fucns nvDAL = new NhanVien_fucns();

        public bool CapNhatNhanVien(NhanVien nv)
        {
            return nvDAL.CapNhatNV(nv);
        }

        public NguoiDung LayThongTinNguoiDung(string _manv)
        {
            return nvDAL.LayThongTinNguoiDung(_manv);
        }

        public void capnhatNVlinQ(string maNV, string hoten, DateTime ngaysinh, string gt, string email, string cmnd, string dc, string sdt)
        {
            nvDAL.capnhatNVlinQ(maNV,hoten, ngaysinh, gt, email,cmnd, dc, sdt);
        }

        public bool kiemTraTrungID(string id)
        {
            return nvDAL.kiemTraTrungID(id);
        }

        public string Hash(string password)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] buffer = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(buffer);
        }

        public string phatsinhMaNV()
        {
            Random rand = new Random();
            string a = rand.Next(1110000, 1999999).ToString();
            return a;
        }

        public bool KiemTraTuoi(DateTime dt)
        {
           int yearNow = DateTime.Now.Year;
           if ((yearNow - dt.Year < 18) || (yearNow - dt.Year > 55))
                return false;
           return true;
        }

    }
}
