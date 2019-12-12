using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyLinhKienMayTinh.connectionEntity
{
    class connection
    {
        public static QLLinhKienMayTinh connectionA;

        public static QLLinhKienMayTinh db
        {
            get
            {
                if (connectionA == null)
                {
                    connectionA = new QLLinhKienMayTinh();
                }
                return connectionA;
            }
        }
    }
}
