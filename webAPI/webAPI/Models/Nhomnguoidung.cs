using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Nhomnguoidung
    {
        public Nhomnguoidung()
        {
            NdNnd = new HashSet<NdNnd>();
            Phanquyen = new HashSet<Phanquyen>();
        }

        public int Id { get; set; }
        public string TenGoi { get; set; }

        public ICollection<NdNnd> NdNnd { get; set; }
        public ICollection<Phanquyen> Phanquyen { get; set; }
    }
}
