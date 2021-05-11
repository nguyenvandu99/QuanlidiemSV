using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Quanlidiemsinhvien
{
    public partial class frmSV : Form
    {
        public frmSV()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        
        SqlConnection con;
        private void NhapSV_Load(object sender, EventArgs e)
        {
            cboMakhoa.DisplayMember = "MaKhoa";
            cboMakhoa.ValueMember = "MaKhoa";
            cboMakhoa.DataSource = dt.SinhVien_SelectMK();
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DataSource = dt.SinhVien_SelectML();


        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
           
            dt.SinhVien_Insert(textMaSV.Text, textHoten.Text,textNgaysinh.Value, textQuequan.Text, cboMaLop.Text, textGioitinh.Text, cboMakhoa.Text);
            NhapSV_Load(sender, e);
        }

        private void btnSaveSV_Click(object sender, EventArgs e)
        {
            
            dt.SinhVien_Update(textMaSV.Text, textHoten.Text, textNgaysinh.Value, textQuequan.Text, cboMaLop.Text, textGioitinh.Text, cboMakhoa.Text);
            NhapSV_Load(sender, e);
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.SinhVien_Delete(textMaSV.Text);
            NhapSV_Load(sender, e);
        }
        

     
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLiDiemSV"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            string sqlSearch = " SELECT * FROM SinhVien WHERE (TenSV like '%" + textSearch.Text + "%') ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sqlSearch, con);
            dap.Fill(ds);
            danhsachsinhvien.DataSource = ds.Tables[0];
            danhsachsinhvien.Refresh();
            cboMakhoa.DataBindings.Clear();
            cboMakhoa.DataBindings.Add("Text", danhsachsinhvien.DataSource, "MaKhoa");
            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", danhsachsinhvien.DataSource, "MaLop");
            textMaSV.DataBindings.Clear();
            textMaSV.DataBindings.Add("Text", danhsachsinhvien.DataSource, "MaSV");
            textHoten.DataBindings.Clear();
            textHoten.DataBindings.Add("Text", danhsachsinhvien.DataSource, "TenSV");
            textNgaysinh.DataBindings.Clear();
            textNgaysinh.DataBindings.Add("Text", danhsachsinhvien.DataSource, "NgaySinh", true);
            textQuequan.DataBindings.Clear();
            textQuequan.DataBindings.Add("Text", danhsachsinhvien.DataSource, "QueQuan");
            textGioitinh.DataBindings.Clear();
            textGioitinh.DataBindings.Add("Text", danhsachsinhvien.DataSource, "GioiTinh");
            con.Close();

        }

        private void cboMakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            danhsachsinhvien.DataSource = dt.SinhVien_SelectMaKhoa(cboMakhoa.SelectedValue.ToString());
            
            textMaSV.DataBindings.Clear();
            textMaSV.DataBindings.Add("Text", danhsachsinhvien.DataSource, "MaSV");
            textHoten.DataBindings.Clear();
            textHoten.DataBindings.Add("Text", danhsachsinhvien.DataSource, "TenSV");
            textNgaysinh.DataBindings.Clear();
            textNgaysinh.DataBindings.Add("Text", danhsachsinhvien.DataSource, "NgaySinh",true);
            textQuequan.DataBindings.Clear();
            textQuequan.DataBindings.Add("Text", danhsachsinhvien.DataSource, "QueQuan");
            textGioitinh.DataBindings.Clear();
            textGioitinh.DataBindings.Add("Text", danhsachsinhvien.DataSource, "GioiTinh");
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            danhsachsinhvien.DataSource = dt.SinhVien_SelectMaLop(cboMaLop.SelectedValue.ToString());
            
            textMaSV.DataBindings.Clear();
            textMaSV.DataBindings.Add("Text", danhsachsinhvien.DataSource, "MaSV");
            textHoten.DataBindings.Clear();
            textHoten.DataBindings.Add("Text", danhsachsinhvien.DataSource, "TenSV");
            textNgaysinh.DataBindings.Clear();
            textNgaysinh.DataBindings.Add("Text", danhsachsinhvien.DataSource, "NgaySinh", true);
            textQuequan.DataBindings.Clear();
            textQuequan.DataBindings.Add("Text", danhsachsinhvien.DataSource, "QueQuan");
            textGioitinh.DataBindings.Clear();
            textGioitinh.DataBindings.Add("Text", danhsachsinhvien.DataSource, "GioiTinh");
        }

        private void textNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void danhsachsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
