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
    public partial class frmDiemtheokhoa : Form
    {
        public frmDiemtheokhoa()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        Xuly xl = new Xuly();
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewSV.Nodes.Clear();
            foreach (var r in dt.SinhVien_SelectMaKhoa(cboKhoa.SelectedValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.TenSV;
                treeViewSV.Nodes.Add(node);
            }
            treeViewSV.ExpandAll();
        }

        private void Diemtheokhoa_Load(object sender, EventArgs e)
        {
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.DataSource = dt.Khoa_SelectAll();
        }

        private void treeViewSV_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void treeViewSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (var r in dt.SinhVien_SelectMaSV(e.Node.Name))
            {
                lbnMaSV.Text = e.Node.Name;
                lbnTenSV.Text = r.TenSV;
                lbnNgaysinh.Text = r.NgaySinh.ToString();
                lbnQuequan.Text = r.QueQuan;
                lbnGioitinh.Text = r.GioiTinh;
            }
            var table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains("MaMH"))
                table.Columns.Add("MaMH", typeof(String));
            if (!col.Contains("TenMH"))
                table.Columns.Add("TenMH", typeof(String));
            if (!col.Contains("SoTC"))
                table.Columns.Add("SoTC", typeof(String));
            if (!col.Contains("DiemHP"))
                table.Columns.Add("DiemHP", typeof(String));
            if (!col.Contains("DiemChu"))
                table.Columns.Add("DiemChu", typeof(String));
            if (!col.Contains("DiemSo"))
                table.Columns.Add("DiemSo", typeof(String));
            Double tong = 0;
            int SoTinChi = 0;
            foreach (var m in dt.MonHP_SelectAll())
            {
                DataRow r = table.NewRow();
                r["MaMH"] = m.MaMH;
                r["TenMH"] = m.TenMH;
                r["SoTC"] = m.SoTC;
                SoTinChi += Convert.ToInt32(m.SoTC);
                foreach (var d in dt.DiemHP_Search(m.MaMH, e.Node.Name))
                {
                    double DiemTK = Convert.ToDouble((((d.DiemKT1 + d.DiemKT2) / 2) * 0.4) + (d.Diemthi * 0.6));
                    r["DiemHP"] = DiemTK;
                    r["DiemChu"] = xl.diemChu(Convert.ToDouble(DiemTK));
                    r["DiemSo"] = xl.diemSo(Convert.ToDouble(DiemTK));
                    tong += xl.diemSo(Convert.ToDouble(DiemTK)) * Convert.ToDouble(m.SoTC);

                }
                table.Rows.Add(r);
            }//end for mon hp
            Double t = Math.Round(tong / SoTinChi, 2);
            dtgDiem.DataSource = table;
            lbnTB.Text = t.ToString();
            lbnXL.Text = xl.xlTK(t);
        }

        private void frmDiemtheokhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
 }

