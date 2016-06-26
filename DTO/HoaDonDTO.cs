using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        

        public int MaHoaDon { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<decimal> TongTien { get; set; }

    }
}
