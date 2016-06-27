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
    public partial class frm_HangHoa : Form
    {
        HangHoaBL hh = new HangHoaBL();
        public frm_HangHoa()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            var l = hh.LayDanhSach();
            gcHH.DataSource = l;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThemHangHoa f = new ThemHangHoa();
            f.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
