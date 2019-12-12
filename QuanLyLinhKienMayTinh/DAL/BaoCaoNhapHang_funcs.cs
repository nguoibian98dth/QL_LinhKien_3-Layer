
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class BaoCaoNhapHang_funcs
    {
        DataSQL dtsql = new DataSQL();
        public DataTable GetSoLanDat()
        {
            string sql = "select ncc.MaNCC, ncc.TenNCC, count(hdm.MaHD) as N'Số lần đặt hàng' from NHACUNGCAP ncc, HOADON_MUAHANG hdm where hdm.MaNCC=ncc.MaNCC AND YEAR(hdm.NgayMua)=YEAR(GETDATE()) group by ncc.MaNCC, ncc.TenNCC HAVING COUNT(hdm.MaHD)>=3 order by COUNT(hdm.MaHD) desc";
            return dtsql.ExecQuery(sql);
        }

        public DataTable GetLKnhapnhieu()
        {
            string sql = "select lk.MaLK, lk.TenLK, sum(cthdm.SoLuong) as'Tổng Số Lượng' from LINHKIEN lk, CT_HOADONMUA cthdm, HOADON_MUAHANG hdm where lk.MaLK=cthdm.MaLK AND hdm.MaHD=cthdm.MaHDM AND MONTH(hdm.NgayMua)=MONTH(GETDATE())group by lk.MaLK, lk.TenLK having sum(cthdm.SoLuong)>100 order by sum(cthdm.SoLuong) desc";
            return dtsql.ExecQuery(sql);
        }

    }
}
