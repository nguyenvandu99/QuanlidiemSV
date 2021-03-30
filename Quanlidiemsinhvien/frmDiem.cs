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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmDiem_Load(object sender, EventArgs e)
        {   
            cboLop.DataSource = dt.Lop_SelectAll();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboHocky.DataSource = dt.HocKy_SelectAll();          
            cboHocky.DisplayMember = "TenHK";
            cboHocky.ValueMember = "MaHK";         
            cboMonHP.DataSource = dt.MonHP_SelectAll();
            cboMonHP.DisplayMember = "TenMH";
            cboMonHP.ValueMember = "MaMH";
            
           

        }

        private void cboHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cboMonHP.DataSource = dt.MonHP_SelectMaHK(cboHocky.SelectedValue.ToString());
            cboMonHP.ValueMember = "MaMH";
            cboMonHP.DisplayMember = "TenMH";
            textMaMH.DataBindings.Clear();
            textMaMH.DataBindings.Add("Text", cboMonHP.DataSource, "MaMH");

        }
        private void cboMonHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgDiem.DataSource = dt.BangDiemHP(cboLop.SelectedValue.ToString(),textMaMH.Text);
            

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonHP_SelectedIndexChanged(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            frmDiem_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           foreach(var m in dt.MonHP_SelectAll())
            {
                foreach (var s in dt.SinhVien_SelectAll())
                {
                    if(dt.DiemHP_Search(m.MaMH,s.MaSV).Count() == 0)
                    {
                        dt.DiemHP_Insert(s.MaSV,m.MaMH);
                    }
                }
            }
            MessageBox.Show("Cập nhập thành công cơ sở dữ liệu điểm học  phần");
            frmDiem_Load(sender, e);
        }

        private void dtgDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgDiem.CurrentCell.RowIndex;
            //if (!String.IsNullOrEmpty((dtgDiem.Rows[i]).Cells["DiemKT1"].Value.ToString())
            //    && !String.IsNullOrEmpty((dtgDiem.Rows[i]).Cells["DiemKT2"].Value.ToString())
            //    && !String.IsNullOrEmpty((dtgDiem.Rows[i]).Cells["Diemthi"].Value.ToString()))
            //{
                dt.DiemHP_Update(dtgDiem.Rows[i].Cells["MaSV"].Value.ToString(),textMaMH.Text
                    ,Convert.ToDouble((dtgDiem.Rows[i]).Cells["DiemKT1"].Value),
                    Convert.ToDouble((dtgDiem.Rows[i]).Cells["DiemKT2"].Value), 
                    Convert.ToDouble((dtgDiem.Rows[i]).Cells["Diemthi"].Value));
            //}
        }

        private void frmDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
 }

