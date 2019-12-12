using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
namespace BUS
{
    public class KiemTraHopLe
    {
        DataSQL dtsql = new DataSQL();
        public static string _maNV;
        NguoiDung_func ndDAL = new NguoiDung_func();

        public bool KiemTraDauVao(string _dl1, string _dl2, string _dl3, string _dl4, string _dl5, string _dl6, string _7)
        {
            if ((_dl1 == "") || (_dl2 == "") || (_dl3 == "") || (_dl4 == "") || (_dl5 == "") || (_dl6 == "") || (_7 == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool KiemTra3DauVao(string _dl1, string _dl2, string _dl3)
        {
            if ((_dl1 == "") || (_dl2 == "") || (_dl3 == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool KiemTraCofirmPassword(string pass, string confirmPass)
        {
            if (String.Compare(pass, confirmPass, false) == 0) //bang nhau, phan biet hoa vs thuong
                return true;
            return false;
        }

        public bool KiemTraPresentPass(string pass)
        {
            string _hashPass = ndDAL.Hash(pass);
            NguoiDung_func._maNV = _maNV;
            if (ndDAL.KiemTraPass(_hashPass))
            {
                return true;
            }
            return false;
        }


        public bool KiemTraDL(string sql, string _dulieu, int _viTriCell)
        {
            DataTable dt = dtsql.ExecQuery(sql);
            string _tam;
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                _tam = dt.Rows[i].ItemArray[_viTriCell].ToString();
                if (_dulieu == _tam)
                {
                    return false;
                    break;
                }
            }
            return true;
        }

        public bool KiemTraDL2(string sql, string _dulieu, int _viTriCell, int _rowIndex)
        {
            DataTable dt = dtsql.ExecQuery(sql);
            string _tam;
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                _tam = dt.Rows[i].ItemArray[_viTriCell].ToString();
                if ((_dulieu == _tam) && (i != _rowIndex))
                {
                    return false;
                    break;
                }
            }
            return true;
        }
    }
}
