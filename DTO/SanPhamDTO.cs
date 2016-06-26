using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> Gia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> DonGia { get; set; }
        public string LoaiSanPham { get; set; }
        public string MaNCC { get; set; }
        public string MaHD { get; set; }
        public Nullable<int> ChietKhau { get; set; }
        public string MaKhoHang { get; set; }
    }
}
