//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.CongNo = new HashSet<CongNo>();
            this.HoaDon = new HashSet<HoaDon>();
        }
    
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string MaThue { get; set; }
        public string TaiKhoan { get; set; }
        public Nullable<int> ChietKhau { get; set; }
        public Nullable<int> GioiHanNo { get; set; }
        public Nullable<int> No { get; set; }
        public string NguoiLienHe { get; set; }
        public string ChucVu { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string TenNganHang { get; set; }
        public string NickYahoo { get; set; }
        public string NickSky { get; set; }
        public string KhuVuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongNo> CongNo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        public virtual KhuVuc KhuVuc1 { get; set; }
    }
}
