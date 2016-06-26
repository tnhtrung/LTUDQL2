using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Model;

namespace BUS
{
    public class HangHoaBL
    {
        public List<DTO.SanPhamDTO> LayDanhSach()
        {
            try
            {
                using (LTUDQLEntities ctx = new LTUDQLEntities())
                {
                    var danhSach = (from n in ctx.SanPham
                                    select new SanPhamDTO
                                    {
                                        SanPhamID = n.SanPhamID,
                                        TenSanPham=n.TenSanPham,
                                        SoLuong=n.SoLuong,
                                        Gia=n.Gia,
                                        ChietKhau=n.ChietKhau,
                                        MaKhoHang=n.MaKhoHang,
                                        
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
        public void Them(SanPhamDTO sp)
        {
            using (LTUDQLEntities ctx = new LTUDQLEntities())
            {

                SanPham n=new SanPham {
                    SanPhamID=sp.SanPhamID,
                    TenSanPham = sp.TenSanPham,
                    SoLuong = sp.SoLuong,
                    Gia = sp.Gia,
                    ChietKhau = sp.ChietKhau,
                    MaKhoHang = sp.MaKhoHang,
                
                };

                ctx.SanPham.Add(n);
                ctx.SaveChanges();
            }
          
        }
       
    }
}
