//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HocVien
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string MaKhoa { get; set; }
    
        public virtual Khoa Khoa { get; set; }
    }
}
