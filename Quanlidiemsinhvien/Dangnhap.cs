using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlidiemsinhvien
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
       
        
        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
        private string getUserName()
        {
            string userName = "";
            string conString = @"Data Source=MRROBOT\SQLEXPRESS;Initial Catalog=QuanLiDiemSV;Persist Security Info=True;User ID=sa;Password=123";
            Console.WriteLine(conString);
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Taikhoan WHERE username ='" + textUsername.Text + "' AND passwd = '" + textPasswd.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        userName = dr["HotenCB"].ToString();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                con.Close();
            }

            return userName;

        }
        private string getID()
        {
            string id = "";            
            string conString = @"Data Source=MRROBOT\SQLEXPRESS;Initial Catalog=QuanLiDiemSV;Persist Security Info=True;User ID=sa;Password=123";
            Console.WriteLine(conString);
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Taikhoan WHERE username ='" + textUsername.Text.Trim() + "' AND passwd = '" + textPasswd.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                con.Close();
            }

            return id;

        }
        public static string ID_User = "";
        public static string User_Name = "";

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            {
            ID_User = getID();
            User_Name = getUserName();
            if (ID_User != "")
            {
                frmMain fmain = new frmMain();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
