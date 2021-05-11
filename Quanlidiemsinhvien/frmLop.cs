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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmLop_Load(object sender, EventArgs e)
        {
            cboMaKhoa.DisplayMember = "MaKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
            cboMaKhoa.DataSource = dt.Lop_SelectMK();
            CboMaHeDT.DisplayMember = "MaHeDT";
            CboMaHeDT.ValueMember = "MaHeDT";
            CboMaHeDT.DataSource = dt.HeDT_SelectMHDT();
            cboMaKH.DisplayMember = "MaKhoaHoc";
            //cboMaKH.ValueMember = "MaKhoaHoc";
            //cboMaKH.DataSource = dt.Khoahoc_SelectKH();
            //dtgLop.DataSource = dt.Lop_SelectAll();

        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgLop.DataSource = dt.Lop_SelectMaKhoa(cboMaKhoa.SelectedValue.ToString());
            textMaLop.DataBindings.Clear();
            textMaLop.DataBindings.Add("Text", dtgLop.DataSource, "MaLop");
            textTenLop.DataBindings.Clear();
            textTenLop.DataBindings.Add("Text", dtgLop.DataSource, "TenLop");


        }

        private void CboMaHeDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgLop.DataSource = dt.Lop_SelectMaHeDT(CboMaHeDT.SelectedValue.ToString());
            textMaLop.DataBindings.Clear();
            textMaLop.DataBindings.Add("Text", dtgLop.DataSource, "MaLop");
            textTenLop.DataBindings.Clear();
            textTenLop.DataBindings.Add("Text", dtgLop.DataSource, "TenLop");

        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgLop.DataSource = dt.Lop_SelectMaKhoaHoc(cboMaKH.SelectedValue.ToString());
            textMaLop.DataBindings.Clear();
            textMaLop.DataBindings.Add("Text", dtgLop.DataSource, "MaLop");
            textTenLop.DataBindings.Clear();
            textTenLop.DataBindings.Add("Text", dtgLop.DataSource, "TenLop");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.Lop_Insert(textMaLop.Text, textTenLop.Text, cboMaKhoa.Text, CboMaHeDT.Text, cboMaKH.Text);
            frmLop_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            dt.Lop_Update(textMaLop.Text, textTenLop.Text, cboMaKhoa.Text, CboMaHeDT.Text, cboMaKH.Text);
            frmLop_Load(sender, e);
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            dt.Lop_Delete(textMaLop.Text);
            frmLop_Load(sender, e);
        }

        private void dtgLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
    


