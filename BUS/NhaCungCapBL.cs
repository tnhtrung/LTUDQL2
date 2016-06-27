using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBL
    {
        public List<DTO.NhaCungCapDTO> DanhSach()
        {
            using (LTUDQLEntities ctx = new LTUDQLEntities())
            {
                var ds = (from n in ctx.NhaCungCap
                          select new NhaCungCapDTO
                          {
                              MaNCC = n.MaNCC,
                              TenNhaCungCap=n.TenNhaCungCap,
                              Fax=n.Fax,
                              DiaChi=n.DiaChi,
                              SDT=n.SDT,
                              Email=n.Email,
                              TenNganHang=n.TenNganHang,
                              MaThue=n.MaThue,

                          }
                        ).ToList();
                return ds;

            }
        }
    }
}
