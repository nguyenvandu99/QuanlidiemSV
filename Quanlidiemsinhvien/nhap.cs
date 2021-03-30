using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;



namespace Quanlidiemsinhvien
{
    public partial class nhap : Form
    {
        public nhap()
        {
            InitializeComponent();
        }
        SqlConnection con;
     
        private void nhap_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLiDiemSV"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            hienthi();
            con.Close();
        }
        public void hienthi()
        {
            string sqlSELECT = "SELECT * FROM DMSV";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            danhsachsinhvien.DataSource = dt;
    
         }

        private void nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
                string sqlINSERT = "INSERT INTO DMSV VALUES (@MaSV,@HoSV,@TenSV,@Phai,@NgaySinh,@NoiSinh,@MaKhoa)";
               SqlCommand cmd = new SqlCommand(sqlINSERT, con);
               cmd.Parameters.AddWithValue("MaSV",textmaSV.Text);
              cmd.Parameters.AddWithValue("HoSV", textHo.Text);
               cmd.Parameters.AddWithValue("TenSV", textTen.Text);
                cmd.Parameters.AddWithValue("Phai", txtGioitinh.Text);
               cmd.Parameters.AddWithValue("NgaySinh", textNgaysinh.Text);
               cmd.Parameters.AddWithValue("NoiSinh", textNoisinh.Text);
               cmd.Parameters.AddWithValue("MaKhoa",textMakhoa.Text);
               cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            hienthi();
            con.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqledit = "UPDATE DMSV SET HoSV=@HoSV,TenSV=@TenSV,Phai=@Phai,NgaySinh=@NgaySinh,NoiSinh=@NoiSinh,MaKhoa=@MaKhoa WHERE MaSV=@MaSV ";
            SqlCommand cmd = new SqlCommand(sqledit, con);
            cmd.Parameters.AddWithValue("MaSV", textmaSV.Text);
            cmd.Parameters.AddWithValue("HoSV", textHo.Text);
            cmd.Parameters.AddWithValue("TenSV", textTen.Text);
            cmd.Parameters.AddWithValue("Phai", txtGioitinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textNgaysinh.Text);
            cmd.Parameters.AddWithValue("NoiSinh", textNoisinh.Text);
            cmd.Parameters.AddWithValue("MaKhoa", textMakhoa.Text);
            cmd.ExecuteNonQuery();
            hienthi();
            MessageBox.Show("Sửa thành công");
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqldelete = "DELETE FROM DMSV WHERE MaSV=@MaSV ";
            SqlCommand cmd = new SqlCommand(sqldelete, con);
            cmd.Parameters.AddWithValue("@MaSV", textmaSV.Text.Trim());
            cmd.Parameters.AddWithValue("HoSV", textHo.Text);
            cmd.Parameters.AddWithValue("TenSV", textTen.Text);
            cmd.Parameters.AddWithValue("Phai", txtGioitinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textNgaysinh.Text);
            cmd.Parameters.AddWithValue("NoiSinh", textNoisinh.Text);
            cmd.Parameters.AddWithValue("MaKhoa", textMakhoa.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            hienthi();
            con.Close();
        }

        private void danhsachsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int numrow;
            numrow = e.RowIndex;
            textmaSV.Text = danhsachsinhvien.Rows[numrow].Cells[0].Value.ToString();
            textHo.Text = danhsachsinhvien.Rows[numrow].Cells[1].Value.ToString();
            textTen.Text = danhsachsinhvien.Rows[numrow].Cells[2].Value.ToString();
            txtGioitinh.Text = danhsachsinhvien.Rows[numrow].Cells[3].Value.ToString();
            textNgaysinh.Text = danhsachsinhvien.Rows[numrow].Cells[4].Value.ToString();
            textNoisinh.Text = danhsachsinhvien.Rows[numrow].Cells[5].Value.ToString();
            textMakhoa.Text = danhsachsinhvien.Rows[numrow].Cells[6].Value.ToString();
            con.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlSearch = " SELECT * FROM DMSV Where (MaSV like '%" + btnSearch.Text + "%') or (TenSV like '%" + btnSearch.Text + "%') ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sqlSearch, con);
            dap.Fill(ds);
            danhsachsinhvien.DataSource = ds.Tables[0];
            danhsachsinhvien.Refresh();
            con.Close();
        }
    }
 }

