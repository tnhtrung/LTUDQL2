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
    public partial class frm_KhuVuc : Form
    {
        KhuVucBL g = new KhuVucBL();
        public frm_KhuVuc()
        {
            InitializeComponent();
        }

        private void frm_KhuVuc_Load(object sender, EventArgs e)
        {
            var l = g.DanhSach();
            gckv.DataSource = l;
        }
    }
}
