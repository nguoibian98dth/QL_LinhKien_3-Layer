using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class LinhKienBUS
    {

        LinhKien_func lkDAL = new LinhKien_func();
        protected static string getYear = "19";

        public bool ThemLinhKien(LinhKien lk)
        {
            return  lkDAL.ThemLinhKien(lk);
        }

        public object getIDsLK()
        {
            return lkDAL.getIDsLK();
        }

        public List<decimal?> getAllGiaNhapLK()
        {
            return lkDAL.getAllGiaNhapLK();
        }

        //public void timkiemtuongdoi(TextBox txtSDT_KH)
        //{
        //    txtSDT_KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    txtSDT_KH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        //    try
        //    {
        //        SqlDataReader drd = lkDAL.getKH();
        //        while (drd.Read())
        //        {
        //            coll.Add(drd["DienThoai"].ToString());
        //        }
        //        txtSDT_KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        txtSDT_KH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        txtSDT_KH.AutoCompleteCustomSource = coll;
        //        drd.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public SqlDataReader getKH()
        {
            return lkDAL.getKH();
        }

        public void CapNhatDonGiaLK(string _maLK)
        {
            try
            {
                lkDAL.CapNhatDonGiaLK(_maLK);
            }
            catch
            {
                return;
            }
        }


        public bool ThemGia_LK(Gia_LK glk)
        {
            return lkDAL.ThemGia_LK(glk);
            
        }

        public bool CapNhatGiaNhap(LinhKien lk)
        {
            return lkDAL.CapNhatGiaNhap(lk);
            
        }

        public void CapNhatLaiSoLuongKhiBan(string _maLK, string _maHDB)
        {
            lkDAL.CapNhatLaiSoLuongKhiBan(_maLK, _maHDB); 
        }

        public void CapNhatLaiSoLuongKhiMua(string _maLK, string _maHDM)
        {
            lkDAL.CapNhatLaiSoLuongKhiMua(_maLK, _maHDM);
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 90)));
                sb.Append(c);
            }
            if (lowerCase)//if true
                return sb.ToString().ToUpper();//in hoa
            return sb.ToString();
        }

        public string phatsinhMa()
        {
            Random rand = new Random();
            string a = rand.Next(10000, 99999).ToString();
            return a;
        }

        public string TaoMa()
        {
            if (phatsinhMa() != "" && RandomString(3, true) != "")
                return getYear + RandomString(3, true) + phatsinhMa();
            else
                return "Error !!";
        }

        public DataTable DanhsachLK()
        {
            return lkDAL.DanhsachLK();
        }

        public DataTable DanhsachLKBanLK()
        {
            return lkDAL.DanhsachLKBanLK();
        }

        public DataTable DanhsachGiaLK(LinhKien lk)
        {
            return lkDAL.DanhsachGiaLK(lk);
        }

        public Gia_LK LayGiaLinhKien(string _maLK)
        {
            return lkDAL.LayGiaLinhKien(_maLK);
        }

        public DataTable LayDSLoaiLK()
        {
            return lkDAL.LayDSLoaiLK();
        }

        public DataTable LayDSNhaCC()
        {
            return lkDAL.LayDSNhaCC();
        }

        public bool XoaLK(LinhKien lk, Gia_LK glk)
        {
            bool isXoaGiaLK = lkDAL.XoaGiaLinhKien(glk);
            bool isXoaLK = lkDAL.XoaLinhKien(lk);
            return isXoaGiaLK && isXoaGiaLK;
        }

        public bool CapNhatGiaLinhKien(Gia_LK glk)
        {
            return lkDAL.CapNhatGiaLinhKien(glk);
            
        }

        public bool SuaTTLinhKien(LinhKien lk)
        {
            return lkDAL.SuaTTLinhKien(lk);
            
        }

        public bool KiemTraNgayCapNhat(Gia_LK glk,DateTime now)
        {
            int KQ = lkDAL.KiemTraNgayCapNhap(glk, now);
            if (KQ == 1)
            {
                return true;
            }
            else
                return false;
        }

        public bool kiemtraTrungIdLK(string _maLK)
        {
            return lkDAL.kiemtraTrungIdLK(_maLK);
        }

        public int laySLLK_LINHKIEN(string idLK)
        {
            return lkDAL.laySLLK_LINHKIEN(idLK);
        }


        public bool kiemTraTrungID(string maLoai)
        {
            return lkDAL.kiemtraTrungID(maLoai);
        }

        public bool CapNhatLoaiLK(string maloaiLK,string tenLoai,string dvt,int thangBH)
        {
            try
            {
                lkDAL.CapNhatLoaiLK(maloaiLK, tenLoai, dvt, thangBH);
                return true;
            }
            catch
            {
                return false;
            }
      
        }
    }

}
