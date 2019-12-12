using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NguoiDung_func
    {

        DataSQL dtsql = new DataSQL();
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.QLLinhKienMayTinhConnectionString);
        public static string _maNV;
        private string defaultPass = "111111";
        private qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();      

        public bool KiemTraPass(string pass)
        {
            string sql = "Select MatKhau from NGUOIDUNG where TaiKhoan= '" + _maNV + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string kq= cmd.ExecuteScalar().ToString();
            if (String.Compare(pass, kq, false) == 0) //bang nhau, phan biet hoa vs thuong
            {
                return true;
            }
            return false;
        }

        public  DataTable layMaManHinhVisible(string maNV)
        {
            string sql = "select *from (select MaManHinh,CoQuyen from PHANQUYEN pq, (select MaNhomND from ND_NND where TaiKhoanND='" + maNV + "') as listND where pq.MaNhomND=listND.MaNhomND group by MaManHinh,CoQuyen) as flag where flag.CoQuyen=1";
            return dtsql.ExecQuery(sql);
        }

        public bool updateNewPassword(string pass)
        {
            try
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd = _qllk.NGUOIDUNGs.Where(t => t.TaiKhoan == _maNV).FirstOrDefault();
                if (nd != null)
                {
                    nd.MatKhau = pass;

                    _qllk.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //bảng băm mã hóa password đăng nhập
        public string Hash(string password)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] buffer = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(buffer);
        }

        public bool KiemTraNguoiDung(NguoiDung user)
        {
            string pass = Hash(user.Str_MatKhau);
            //            string pass = user.MatKhau;

            string sql = "select * from NguoiDung where TaiKhoan = '" + user.Str_MaNV + "' and MatKhau = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  int Check_config()
        {
            if(DAL.Properties.Settings.Default.QLLinhKienMayTinhConnectionString == string.Empty)
                return 1;//chuối cấu hình không tồn tại
            SqlConnection _Sqlconn= new SqlConnection(DAL.Properties.Settings.Default.QLLinhKienMayTinhConnectionString);

            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// ket nối thành công cấu hình hợp lệ
            }
            catch
            {
                return 2;// chuối cấu hình k phù hợp
            }
        }       

        public int KiemTraNguoiDungv2(NguoiDung user)
        {
            string pass = Hash(user.Str_MatKhau);
            //            string pass = user.MatKhau;        
            string sql = "select * from NguoiDung where TaiKhoan = '" + user.Str_MaNV + "' and MatKhau = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                string sql2 = "select TinhTrang from NguoiDung where TaiKhoan = '" + user.Str_MaNV + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int flag= Convert.ToInt32(cmd2.ExecuteScalar());

                if ((int)flag == 1)
                    return 1;//tk tồn tại và k bị block
                else
                    return 2;// tk tồn tại và đang bị block
            }
            else
            {
                return 0;//sai tk và mk
            }
        }

        public  bool ThemNguoiDung(NguoiDung nd)
        {
            try
            {
                string pass = Hash(nd.Str_MatKhau);
                string sql = "insert into NGUOIDUNG(TaiKhoan, MatKhau, PhanQuyen, MaNV) values('" + nd.Str_MaNV + "','" + pass + "','" + nd.Str_Quyen + "','" + nd.Str_MaNV + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandText = sql;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
               // MessageBox.Show(ex.Message);

            }
        }

        public void resetPassword(string _taikhoan)
        {
            string _hashDefaultPass = Hash(defaultPass);
            NGUOIDUNG nd = new NGUOIDUNG();
            nd = _qllk.NGUOIDUNGs.Where(t => t.TaiKhoan == _taikhoan).FirstOrDefault();
            if (nd != null)
            {
                nd.MatKhau = _hashDefaultPass;

                _qllk.SubmitChanges();
            }
        }

        public  DataTable layMaNhomND(string maNV)
        {
            string sql = "select  MaNhomND from ND_NND where TaiKhoanND = '" + maNV + "'";
            return dtsql.ExecQuery(sql);
        }

        public DataTable layManHinhNhomND(int maNhomND)
        {
            string sql = "select* from PHANQUYEN where MaNhomND=" + maNhomND + "";
            return dtsql.ExecQuery(sql);
        }

        public List<int> ListMaNhomND(string maNV)
        {
            List<int> list = new List<int>();
            DataTable dt = layMaNhomND(maNV);
            foreach (DataRow drct in dt.Rows)
            {
                list.Add(Convert.ToInt32(drct["MaNhomND"].ToString()));
            }
            return list;
        }

       

        public  DataTable layMaManHinhBiKhoa(int maNhomND)
        {
            string sql = "select * from PHANQUYEN where MaNhomND=" + maNhomND + " and CoQuyen=0";
            return dtsql.ExecQuery(sql);
        }
    }
}
