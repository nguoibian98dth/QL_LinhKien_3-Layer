using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class GiaLk
    {
        public string MaLk { get; set; }
        public DateTime NgayApDung { get; set; }
        public decimal? GiaBan { get; set; }

        public Linhkien MaLkNavigation { get; set; }
    }
}
