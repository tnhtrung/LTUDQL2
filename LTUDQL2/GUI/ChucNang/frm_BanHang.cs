using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDQL2
{
    public partial class frm_BanHang : Form
    {
        public frm_BanHang()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_KhachHang bh = new frm_KhachHang();

            bh.Show();

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcBH_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
