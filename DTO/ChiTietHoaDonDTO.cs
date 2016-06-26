using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public string SanPhamID { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> TongTien { get; set; }

    }
}
