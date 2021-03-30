using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Quanlidiemsinhvien
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        
        QLDDataContext dt = new QLDDataContext();


        private void frmLop_Load(object sender, EventArgs e)
        {
            dtgKhoa.DataSource = dt.Khoa_SelectAll();
            

        }

        private void dtgKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int numrow;
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                numrow = e.RowIndex;
                textMaKhoa.Text = dtgKhoa.Rows[numrow].Cells[0].Value.ToString();
                textTenKhoa.Text = dtgKhoa.Rows[numrow].Cells[1].Value.ToString();
                TextDiachi.Text = dtgKhoa.Rows[numrow].Cells[2].Value.ToString();
                textSDT.Text = dtgKhoa.Rows[numrow].Cells[3].Value.ToString();
            }
        }
        Boolean adKhoa = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            textMaKhoa.Clear();
            textTenKhoa.Clear();
            TextDiachi.Clear();
            textSDT.Clear();
            adKhoa = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (adKhoa) 
            {
                dt.Khoa_Insert(textMaKhoa.Text, textTenKhoa.Text, TextDiachi.Text, textSDT.Text);
                adKhoa = false;
                frmLop_Load(sender, e);
            }
            else 
            {
                dt.Khoa_Update(textMaKhoa.Text, textTenKhoa.Text, TextDiachi.Text, textSDT.Text);
            }
            frmLop_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.Khoa_Delete(textMaKhoa.Text);
            frmLop_Load(sender, e);
        }

        private void dtgKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
