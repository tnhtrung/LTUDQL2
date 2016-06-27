using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoHangBL
    {
        public List<DTO.KhoHangDTO> DanhSach()
        {
            using (LTUDQLEntities ctx = new LTUDQLEntities())
            {
                var ds = (from n in ctx.KhoHang
                          select new KhoHangDTO
                          {
                              MaKhoHang = n.MaKhoHang,
                              Ten = n.Ten,
                              SDT = n.SDT,
                              NguoiQL = n.NguoiQL,
                              Email = n.Email,
                              Fax = n.Fax,
                          }
                        ).ToList();
                return ds;

            }
        }
    }
}
