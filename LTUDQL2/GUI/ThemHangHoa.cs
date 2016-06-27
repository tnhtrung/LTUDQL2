using BUS;
using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDQL2.GUI
{
    public partial class ThemHangHoa : Form
    {
        HangHoaBL hh = new HangHoaBL();
        NhaCungCapBL kk = new NhaCungCapBL();
     
        public ThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp;
            sp = new SanPhamDTO();
            sp.SanPhamID = (txtma.EditValue == null) ? "" : txtma.EditValue.ToString();
            sp.TenSanPham = (txtten.EditValue == null) ? "" : txtten.EditValue.ToString();                
            hh.Them(sp);

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
           

        }


        private void cbkho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            ThemHangHoa g = new ThemHangHoa();
            g.Close();
        }
    }
}
