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
    public partial class frmHocKy : Form
    {
        public frmHocKy()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmHocKy_Load(object sender, EventArgs e)
        {
            dtgHK.DataSource = dt.HocKy_SelectAll();
        }

        private void dtgHK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;

            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                numrow = e.RowIndex;
                textMaHK.Text = dtgHK.Rows[numrow].Cells[0].Value.ToString();
                textTenHK.Text = dtgHK.Rows[numrow].Cells[1].Value.ToString();
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.HocKy_Insert(textMaHK.Text, textTenHK.Text);
            frmHocKy_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt.HocKy_Update(textMaHK.Text, textTenHK.Text);
            frmHocKy_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.HocKy_Delete(textMaHK.Text);
            frmHocKy_Load(sender, e);
        }

        private void dtgHK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHocKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
