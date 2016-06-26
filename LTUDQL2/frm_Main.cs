using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LTUDQL2.GUI.DanhMuc;
using LTUDQL2.GUI;
using LTUDQL2.GUI.HeThong;
using LTUDQL2.GUI.ChucNang;

namespace LTUDQL2
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void galleryControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThongTin f = new frm_ThongTin();
            if (KiemTraTonTai(f)) return;
            f.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_BanHang bh = new frm_BanHang();
            if (KiemTraTonTai(bh)) return;
            bh.MdiParent = this;
            bh.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThuTien f = new frm_ThuTien();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_MuaHang f = new frm_MuaHang();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_HangHoa f = new frm_HangHoa();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_KhachHangDM f = new frm_KhachHangDM();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiMatKhau f = new frm_DoiMatKhau();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Saoluu f = new frm_Saoluu();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhucHoi f = new frm_PhucHoi();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_KhuVuc f = new frm_KhuVuc();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhaCungCapDM f = new frm_NhaCungCapDM();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_KhoHang fn = new frm_KhoHang();
            if (KiemTraTonTai(fn)) return;
            fn.MdiParent = this;
            fn.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DonViTinh f = new frm_DonViTinh();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhomHang f = new frm_NhomHang();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
              
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_TyGia f = new frm_TyGia();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_BoPhan f = new frm_BoPhan();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhanVien f = new frm_NhanVien();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_TonKho f = new frm_TonKho();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ChuyenKhoa f = new frm_ChuyenKhoa();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_TraTien f = new frm_TraTien();
            if (KiemTraTonTai(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private bool KiemTraTonTai(Form form)
        {
            foreach(var child in MdiChildren)
            {
                if(child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }

            }
            return false;
        }
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}
