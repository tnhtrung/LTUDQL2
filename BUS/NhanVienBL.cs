using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBL
    {
        public List<DTO.NhanVienDTO> DanhSach()
        {
            using (LTUDQLEntities ctx = new LTUDQLEntities())
            {
                var ds = (from n in ctx.NhanVien
                          select new NhanVienDTO
                          {
                             MaNV=n.MaNV,
                             TenNV=n.TenNV,
                             DiaChi=n.DiaChi,
                             SDT=n.SDT,
                             Email=n.Email,

                          }
                        ).ToList();
                return ds;

            }
        }
    }
}
