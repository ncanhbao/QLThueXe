//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class DATXE
    {
        public System.DateTime NgayDatXe { get; set; }
        public int MaKhach { get; set; }
        public int MaXe { get; set; }
        public Nullable<int> SoLuongDat { get; set; }
        public Nullable<System.DateTime> NgayHenLay { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual KHACH KHACH { get; set; }
        public virtual XE XE { get; set; }
    }
}
