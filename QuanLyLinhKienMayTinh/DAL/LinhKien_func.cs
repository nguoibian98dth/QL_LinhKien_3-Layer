using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class LinhKien_func
    {
        DataSQL dtsql = new DataSQL();
        protected SqlConnection conn = new SqlConnection(DAL.Properties.Settings.Default.QLLinhKienMayTinhConnectionString);
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();
        DateTime now = DateTime.Now;

        public bool ThemLinhKien(LinhKien lk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
               // string newBarcode = LinhKienBUS.TaoMa();
                string sql_Them = "insert into LinhKien(MaLK,TenLK,LoaiLK,NhaSX,XuatXu,NamSX,SoLuong,MaNCC) values ('" +
               lk.Str_MaLK + "',N'" +
               lk.Str_TenLK + "','" +
               lk.Str_LoaiLK + "','" +
               lk.Str_NSX + "','" +
               lk.Str_XuatXu + "','" +
               lk.NamSX1 + "'," +
               lk.SoLuong1 + ",'" +
               lk.Str_MaNCC + "')";
               dtsql.ExecNonQuery(sql_Them);
                return true;
            }
            catch(Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        public void CapNhatLaiSoLuongKhiBan(string _maLK, string _maHDB)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql_Proc = string.Format("execute CapNhatSoLuong_sauBan'{0}','{1}'", _maLK, _maHDB);
                dtsql.ExecNonQuery(sql_Proc);
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }

        public void CapNhatLaiSoLuongKhiMua(string _maLK, string _maHDM)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql_Proc = string.Format("execute CapNhatSoLuong_saumUA'{0}','{1}'", _maLK, _maHDM);
                dtsql.ExecNonQuery(sql_Proc);
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }

        public DataTable LayDSNhaCC()
        {
            string sql_ncc = "select * from NhaCungCap";
            return dtsql.ExecQuery(sql_ncc);
        }

        public void CapNhatDonGiaLK(string _maLK)
        {
            try
            {
                double giaNhap = Convert.ToDouble(getGiaNhapLK(_maLK));
                double tile = getPhanTramLoiNhuan();

                double giaBan = giaNhap + (giaNhap * tile / 100);
                string sql = "insert GIA_LK values('" + _maLK + "','" + now + "'," + giaBan + ")";
                dtsql.ExecNonQuery(sql);
            }
            catch (Exception ex)
            { 
            }
        }

        public object getGiaNhapLK(string _maLK)
        {
            string sql = "select giaNhap from LINHKIEN where MaLK ='"+_maLK+"'";
            return dtsql.ExecuteScalar(sql);
        }

        public int  getPhanTramLoiNhuan()
        {
            string sql = "select TiLeGiaBan from THAMSO ";
            return (int)dtsql.ExecuteScalar(sql);
        }


        public DataTable LayDSLoaiLK()
        {
            string sql_loaiLK = "select MaLoai , TenLoai, DVT from LOAI_LK";
            return dtsql.ExecQuery(sql_loaiLK);
        }

        public DataTable DanhsachLK()
        {
            // tao cau sql lay DL
            string sql_LK =
                "select  lk.MaLK,lk.TenLK,l.TenLoai,glk.GiaBan,LK.NhaSX,lk.XuatXu,lk.NamSX,ncc.TenNCC from LINHKIEN lk, LOAI_LK l, NHACUNGCAP ncc, GiaLinhKienUpdated glk where lk.LoaiLK=l.MaLoai and ncc.MaNCC=lk.MaNCC and lk.MaLK=glk.MaLK  GROUP BY  lk.MaLK,lk.TenLK,l.TenLoai,glk.GiaBan,LK.NhaSX,lk.XuatXu,lk.NamSX,ncc.TenNCC,NgayApDung ";
            return dtsql.ExecQuery(sql_LK);
        }

        public Gia_LK LayGiaLinhKien(string _maLK)
        {
            try
            {
                string sql = "Select * from GiaLinhKienUpdated where MaLK = '" + _maLK + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Gia_LK glk = new Gia_LK();
                    glk.GiaBan1 = dt.Rows[0][1].ToString();
                    return glk;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

      
        public bool kiemtraTrungIdLK(string _maLK)
        {
            var kt = from k in _qllk.LINHKIENs
                     where k.MaLK == _maLK
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public DataTable DanhsachLKBanLK()
        {
            //có thêm soluong
            string sql_LK =
                "select  lk.MaLK,lk.TenLK,l.TenLoai,lk.SoLuong,glk.GiaBan,LK.NhaSX,lk.XuatXu,lk.NamSX,ncc.TenNCC from LINHKIEN lk, LOAI_LK l, NHACUNGCAP ncc, GiaLinhKienUpdated glk where lk.LoaiLK=l.MaLoai and ncc.MaNCC=lk.MaNCC and lk.MaLK=glk.MaLK and glk.GiaBan > 0 GROUP BY  lk.MaLK,lk.TenLK,l.TenLoai,lk.SoLuong,glk.GiaBan,LK.NhaSX,lk.XuatXu,lk.NamSX,ncc.TenNCC,NgayApDung ";
            return dtsql.ExecQuery(sql_LK);
        }

        public DataTable DanhsachGiaLK(LinhKien lk)
        {
            try
            {
                // tao cau sql lay DL
                string sql_LK =
                    "select NgayApDung, GiaBan FROM GIA_LK where MaLK='" + lk.Str_MaLK + "' order by NgayApDung DESC ";
                return dtsql.ExecQuery(sql_LK);
            }
            catch
            {
                return null;
            }
        }

        public bool ThemGia_LK(Gia_LK glk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
               string sql_Them = "INSERT INTO GIA_LK(MaLK,NgayApDung,GiaBan) Values ('" +
               glk.Str_maLK + "',N'" +
               glk.NgayApDung1 + "','" +
               glk.GiaBan1 + "')";
               dtsql.ExecNonQuery(sql_Them);
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool CapNhatGiaNhap(LinhKien lk)
        {
            try
            {
                string sql_Them = "update LinhKien  set " + "GiaNhap = " + "'" + lk.GiaNhap + "' where MaLK= '" + lk.Str_MaLK+ "'";

                dtsql.ExecNonQuery(sql_Them);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaGiaLinhKien(Gia_LK glk)
        {
            try
            {
                string sqp_Xoa = "delete from Gia_LK where MaLK = '" + glk.Str_maLK + "' ";
                dtsql.ExecNonQuery(sqp_Xoa);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaLinhKien(LinhKien lk)
        {
            try
            {
                string sqp_Xoa = "delete from LinhKien where MaLK = '" + lk.Str_MaLK +"' ";

                dtsql.ExecNonQuery(sqp_Xoa);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatLK(LinhKien lk)
        {
            try
            {
                string sql_Sua = "update LinhKien set " +
                    "TenLK = " + "'" + lk.Str_TenLK + "' ," +
                    "LoaiLK = " + "'" + lk.Str_LoaiLK + "'," +
                    "NhaSX = " + "'" + lk.Str_NSX + "'," +
                    "XuatXu = " + "'" + lk.Str_XuatXu + "'," +
                    "NamSx = " + "" + lk.NamSX1 + "," +
                    "NhaCC = " + "'" + lk.Str_MaNCC + "'," +
                    "SoLuong = " + "'" + lk.SoLuong1 + "' " +
                    " where id = " + lk.Str_MaLK;

                dtsql.ExecNonQuery(sql_Sua);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatGiaLinhKien(Gia_LK glk)
        {
            try
            {
                string sql_SuaGialk = "insert into Gia_LK(MaLK,NgayApDung,GiaBan) Values('"+glk.Str_maLK+"', '"+glk.NgayApDung1+"', '"+glk.GiaBan1+"')";

                dtsql.ExecNonQuery(sql_SuaGialk);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTTLinhKien(LinhKien lk)
        {
            try
            {
                string sql_SuaTTlk = "update LINHKIEN SET TENLK = '" + lk.Str_TenLK + "', LOAILK='" + lk.Str_LoaiLK + "', NHASX= '" + lk.Str_NSX + "',XUATXU= '" + lk.Str_XuatXu + "', NAMSX='" + lk.NamSX1 + "', MANCC='" + lk.Str_MaNCC + "' where MaLK = '" + lk.Str_MaLK + "' ";
                dtsql.ExecNonQuery(sql_SuaTTlk);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DateTime LayNgayCapNhatGiaCuoiCung(Gia_LK glk)
        {
            try
            {
                string sql = "select TOP 1 WITH ties (NgayApDung) from GIA_LK where MaLK='" + glk.Str_maLK + "'ORDER BY (NgayApDung) DESC";
                return (DateTime)dtsql.ExecuteScalar(sql);
            }
            catch
            {
                return Convert.ToDateTime("1/1/1990");
            }

        }

        public int KiemTraNgayCapNhap(Gia_LK glk,DateTime now)
        {
            try
            {
                int ktra_KQ;
                string kt_sql = "select DATEDIFF(day,'"+LayNgayCapNhatGiaCuoiCung(glk)+"','" + now + "')";//hàm
                ktra_KQ = (int)dtsql.ExecuteScalar(kt_sql);
                if (ktra_KQ > 0)
                    return 1;//hợp lệ
                return 2;// ko hợp lệ xuất thông báo
            }
            catch
            {
                return 0;//xuất thông báo lỗi không hợp lệ
            }
        }

        public object getIDsLK()
        {
            var kt = from k in _qllk.LINHKIENs
                     select k.MaLK;
            return kt.ToList();
        }

        public List<decimal?> getAllGiaNhapLK()
        {
            var kt = from k in _qllk.LINHKIENs
                     select k.GiaNhap;
            return (List<decimal?>)kt.ToList();

        }



        public SqlDataReader getKH()
        {
            string s = "SELECT *FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(s, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return cmd.ExecuteReader();
        }

        public int laySLLK_LINHKIEN(string idLK)
        {
            var kt = (from k in _qllk.LINHKIENs
                      where k.MaLK == idLK
                      select k.SOLUONG).FirstOrDefault();
            int flag = Convert.ToInt32(kt);
            return flag;
        }

        public bool kiemtraTrungID(string maLoai)
        {
            var kt = from k in _qllk.LOAI_LKs
                     where k.MaLoai == maLoai
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public void CapNhatLoaiLK(string maLoai, string tenLoai, string dvt, int thangBH)
        {
            try
            {
                LOAI_LK llk = new LOAI_LK();
                llk = _qllk.LOAI_LKs.Where(t => t.MaLoai == maLoai).FirstOrDefault();
                if (llk != null)
                {
                    llk.TenLoai = tenLoai;
                    llk.DVT = dvt;
                    llk.ThangBH = thangBH;
                    _qllk.SubmitChanges();
                }
            }
            catch
            {
                return;
            }
            
        }

    }
}
