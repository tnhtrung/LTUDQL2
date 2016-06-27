using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDQL2.GUI.DanhMuc
{
    public partial class frm_KhoHang : Form
    {
        KhoHangBL g = new KhoHangBL();
        public frm_KhoHang()
        {
            InitializeComponent();
        }

        private void frm_KhoHang_Load(object sender, EventArgs e)
        {
            var l = g.DanhSach();
            gckh.DataSource = l;
        }
    }
}
