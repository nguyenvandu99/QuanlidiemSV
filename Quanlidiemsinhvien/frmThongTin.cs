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
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmThongTin_Load(object sender, EventArgs e)
        {
            textTinh.DataBindings.Clear();
            textTinh.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "Tinh");
            textDonViChuQuan.DataBindings.Clear();
            textDonViChuQuan.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "DonViChuQuan");
            textTruong.DataBindings.Clear();
            textTruong.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "TenTruong");
            textKhoahoc.DataBindings.Clear();
            textKhoahoc.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "KhoaHoc");
            textNganhhoc.DataBindings.Clear();
            textNganhhoc.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "NganhHoc");
            textChuyennganh.DataBindings.Clear();
            textChuyennganh.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "ChuyenNganh");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dt.ThongTin_Update(textTinh.Text, textDonViChuQuan.Text, textTruong.Text, textKhoahoc.Text, textNganhhoc.Text, textChuyennganh.Text);
            frmThongTin_Load(sender, e);
        }

        private void frmThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
