using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuVucBL
    {
        public List<DTO.KhuVucDTO> DanhSach()
        {
            using (LTUDQLEntities ctx = new LTUDQLEntities())
            {
                var ds = (from n in ctx.KhuVuc
                          select new KhuVucDTO
                          {
                              MaKV=n.MaKV,
                              TenKV=n.TenKV,
                              NguoiQL=n.NguoiQL,
                          }
                        ).ToList();
                return ds;

            }
        }
    }
}
