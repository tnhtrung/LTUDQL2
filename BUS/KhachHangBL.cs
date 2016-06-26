using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Model;
namespace BUS
{
    public class KhachHangBL
    {
       public List<DTO.KhachHangDTO> LayDanhSach()
        {
            try
            {
                using (LTUDQLEntities ctx = new LTUDQLEntities())
                {
                    var danhSach = (from n in ctx.KhachHang
                                    select new KhachHangDTO
                                    {
                                        MaKH = n.MaKH,
                                        TenKH = n.TenKH,
                                        SDT = n.SDT,
                                        DiaChi = n.DiaChi,
                                        Email = n.Email,
                                        NguoiLienHe = n.NguoiLienHe,
                                        Fax = n.Fax,
                                        TenNganHang = n.TenNganHang,
                                        KhuVuc = n.KhuVuc
                                    }).ToList();
                                    ;
                    return danhSach;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
