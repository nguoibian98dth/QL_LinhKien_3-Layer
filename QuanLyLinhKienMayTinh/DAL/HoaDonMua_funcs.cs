using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonMua_funcs
    {
        DataSQL dtsql = new DataSQL();
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();

        public bool kiemtraTrungIdHDMua(string ma)
        {
            var kt = from k in _qllk.HOADON_MUAHANGs
                     where k.MaHD == ma
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool kiemtraTrungIdCTHDMua(string ma)
        {
            var kt = from k in _qllk.CT_HOADONMUAs
                     where k.Ma_CTHD == ma
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public int LaySoLuongTon(string _maLK)
        {
            try
            {
                string sql = "select SoLuong from LinhKien where MaLK = '" + _maLK.ToString() + "'";

                int _soLuong = int.Parse(dtsql.ExecQuery(sql).Rows[0].ItemArray[0].ToString());

                return _soLuong;
            }
            catch
            {
                return -1;
            }

        }

        public DataTable LayDuLieuThamSo()
        {
            string sql = "select SLMuaToiDa,  SLTonToiDa from ThamSo ";
            return dtsql.ExecQuery(sql);
        }
    }
}
