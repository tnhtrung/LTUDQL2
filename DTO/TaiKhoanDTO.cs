﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int TaiKhoanID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenDayDu { get; set; }
        public Nullable<int> QuyenHan { get; set; }
    }
}
