using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyLinhKienMayTinh.LuuTru;
using QuanLyLinhKienMayTinh.XuLy;
using System.Data;

namespace QuanLyLinhKienMayTinh.BUS
{
    class BanLKBUS
    {
        public static DataTable LayThongTinKH(string sdt)
        {

            // tao cau sql lay DL
            string sql_kh =
                "Select MaKH, TenKH, DiaChi From KHACHHANG Where DienThoai= ' " + sdt + " ' ";
            return DataSQL.ExecQuery(sql_kh);
        }
    }
}
