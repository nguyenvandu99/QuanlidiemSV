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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            cboMaHK.DisplayMember = "MaHK";
            cboMaHK.ValueMember = "MaHK";
            cboMaHK.DataSource = dt.MonHP_SelectHK();
            cboMaKhoa.DisplayMember = "MaKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
            cboMaKhoa.DataSource = dt.MonHP_SelectMK();
            
        }

        private void cboMaHK_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtgMonHoc.DataSource = dt.MonHP_SelectMaHK(cboMaHK.SelectedValue.ToString());
            
            textMaMH.DataBindings.Clear();
            textMaMH.DataBindings.Add("Text", dtgMonHoc.DataSource, "MaMH");
            textTenMH.DataBindings.Clear();
            textTenMH.DataBindings.Add("Text", dtgMonHoc.DataSource, "TenMH");
            textSoTC.DataBindings.Clear();
            textSoTC.DataBindings.Add("Text", dtgMonHoc.DataSource, "SoTC");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.MonHP_Insert(textMaMH.Text, textTenMH.Text, Convert.ToInt16(textSoTC.Text), cboMaHK.Text, cboMaKhoa.Text);
            frmMonHoc_Load(sender, e);
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgMonHoc.DataSource = dt.MonHP_SelectMaKhoa(cboMaKhoa.SelectedValue.ToString());
            
            textMaMH.DataBindings.Clear();
            textMaMH.DataBindings.Add("Text", dtgMonHoc.DataSource, "MaMH");
            textTenMH.DataBindings.Clear();
            textTenMH.DataBindings.Add("Text", dtgMonHoc.DataSource, "TenMH");
            textSoTC.DataBindings.Clear();
            textSoTC.DataBindings.Add("Text", dtgMonHoc.DataSource, "SoTC");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt.MonHP_Update(textMaMH.Text, textTenMH.Text, Convert.ToInt16(textSoTC.Text), cboMaHK.Text, cboMaKhoa.Text);
            frmMonHoc_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.MonHP_Delete(textMaMH.Text);
            frmMonHoc_Load(sender, e);
        }

        private void dtgMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
