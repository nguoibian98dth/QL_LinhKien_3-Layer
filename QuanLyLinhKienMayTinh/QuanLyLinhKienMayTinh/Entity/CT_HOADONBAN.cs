//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLinhKienMayTinh.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_HOADONBAN
    {
        public string Ma_CTHD { get; set; }
        public string MaHDB { get; set; }
        public string MaLK { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
    
        public virtual HOADON_BANHANG HOADON_BANHANG { get; set; }
        public virtual LINHKIEN LINHKIEN { get; set; }
    }
}
