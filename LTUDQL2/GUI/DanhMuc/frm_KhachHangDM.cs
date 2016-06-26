using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Model;
namespace LTUDQL2.GUI.DanhMuc
{
    public partial class frm_KhachHangDM : Form
    {
        KhachHangBL khbl = new KhachHangBL();
        public frm_KhachHangDM()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void vGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_KhachHangDM_Load(object sender, EventArgs e)
        {
            var l = khbl.LayDanhSach();
            gcKH.DataSource = l;
        }
    }
}
