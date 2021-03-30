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
    public partial class ListKhoa : Form
    {
        public ListKhoa()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void DsKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListKhoa_Load(object sender, EventArgs e)
        {
            DsKhoa.DataSource = dt.Khoa_SelectAll();
        }

        private void ListKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
