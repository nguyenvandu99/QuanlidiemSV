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
    public partial class ListHocKy : Form
    {
        public ListHocKy()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void ListHocKy_Load(object sender, EventArgs e)
        {
            DsHocKy.DataSource = dt.HocKy_SelectAll();
        }

        private void ListHocKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
