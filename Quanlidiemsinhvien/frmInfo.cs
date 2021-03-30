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
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();

        private void frmInfo_Load(object sender, EventArgs e)
        {
            lbnTenTinh.DataBindings.Clear();
            lbnTenTinh.DataBindings.Add("Text",dt.ThongTin_SelecAll(), "Tinh");
            lbnDonViChuQuan.DataBindings.Clear();
            lbnDonViChuQuan.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "DonViChuQuan");
            LbnChuyenNganh.DataBindings.Clear();
            LbnChuyenNganh.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "ChuyenNganh");
            lbnKhoaHoc.DataBindings.Clear();
            lbnKhoaHoc.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "KhoaHoc");
            lbnTenTruong.DataBindings.Clear();
            lbnTenTruong.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "TenTruong");
            lbnNganhHoc.DataBindings.Clear();
            lbnNganhHoc.DataBindings.Add("Text", dt.ThongTin_SelecAll(), "NganhHoc");
        }

        private void frmInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
