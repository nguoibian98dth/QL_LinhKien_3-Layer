using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            NdNnd = new HashSet<NdNnd>();
        }

        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool? TinhTrang { get; set; }

        public Nhanvien TaiKhoanNavigation { get; set; }
        public ICollection<NdNnd> NdNnd { get; set; }
    }
}
