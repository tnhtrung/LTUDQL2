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
    
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            this.CongNo = new HashSet<CongNo>();
            this.SanPham = new HashSet<SanPham>();
        }
    
        public string MaNCC { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string MaThue { get; set; }
        public string TaiKhoan { get; set; }
        public Nullable<int> ChietKhau { get; set; }
        public Nullable<int> GioiHanNo { get; set; }
        public string NguoiLienHe { get; set; }
        public string ChucVu { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string TenNganHang { get; set; }
        public string KhuVuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongNo> CongNo { get; set; }
        public virtual KhuVuc KhuVuc1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
