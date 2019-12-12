using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class BaoCaoBanHang_funcs
    {
        DataSQL dtsql = new DataSQL();
        public DataTable layDuLieuBXH_LK()
        {
            string sql = "select b.MaLK,TenLK, sum(a.SoLuong) as N'Đã bán' from CT_HOADONBAN a,LINHKIEN b, HOADON_BANHANG c where c.MaHD=a.MaHDB and TinhTrang=1 and b.MaLK=a.MaLK group by b.MaLK,TenLK order by sum(a.SoLuong) desc";
            return dtsql.ExecQuery(sql);
        }

        public DataTable layDuLieuBXH_NV()
        {
            string sql = "select nv.MaNV,HoTen,sum(TongTien) as N'Doanh số' from NHANVIEN nv, HOADON_BANHANG hdb where nv.MaNV=hdb.MaNV and TinhTrang=1 group by nv.MaNV,HoTen order by sum(TongTien) desc";
            return dtsql.ExecQuery(sql);
        }

        public DataTable layDuLieuHDB()
        {
            string sql = "select * from HOADON_BANHANG where TinhTrang=1 order by NgayLap desc";
            return dtsql.ExecQuery(sql);
        }
    }
}
