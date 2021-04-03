using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlidiemsinhvien
{
    public partial class frmDSKhoa : Form
    {
        public frmDSKhoa()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            DsSinhVien.DataSource = dt.SinhVien_SelectAll();
            
        }

        private void frmDSKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
