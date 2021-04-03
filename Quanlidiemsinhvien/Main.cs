using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlidiemsinhvien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
           
            InitializeComponent();
        }
        string UID = Dangnhap.ID_User;
        string UName = Dangnhap.User_Name;
         
        List<string> list_detail = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            list_detail = List_per();
            lblUsername.Text = UName;
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            //Danhsach frm = new Danhsach();
            //frm.MdiParent = this;
            //frm.Show();
        }

        
      
        private void btnHethong_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmInfo frm1 = new frmInfo();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void cậpNhậpThôngTinLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (checkper("ALL") == true || checkper("FULL") == true )
            {
                frmLop frmlop = new frmLop();
                frmlop.MdiParent = this;
                frmlop.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
           
        }

        private void cậpNhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkper("ALL") == true || checkper("FULL") == true || checkper("EDIT") == true)
            {
                frmDiem frmdiem = new frmDiem();
                frmdiem.MdiParent =  this;
                frmdiem.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            
        }

        private void cậpNhậpThôngTinHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkper("ALL") == true)
            {
                frmThongTin frmTH = new frmThongTin();
                frmTH.MdiParent = this;
                frmTH.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
        }

        private void cậpNhậpKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkper("ALL") == true || checkper("FULL") == true )
            {
                frmKhoa frmKhoa = new frmKhoa();
                frmKhoa.MdiParent = this;
                frmKhoa.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
        }

        private void cậpNhậpHọcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkper("ALL") == true || checkper("FULL") == true )
            {
                frmHocKy frmHK = new frmHocKy();
                frmHK.MdiParent = this;
                frmHK.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
        }

        private void cậpNhậpMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkper("ALL") == true || checkper("FULL") == true )
            {
                frmMonHoc frmMH = new frmMonHoc();
                frmMH.MdiParent = this;
                frmMH.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
        }

        private void cậpNhậpSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkper("ALL") == true || checkper("FULL") == true)
            {
                frmSV sv = new frmSV();
                sv.MdiParent = this;
                sv.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vui lòng liên hệ quản trị viên");
            }
        }

        private void xemĐiểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemtheolop frmBTH = new frmDiemtheolop();
            frmBTH.MdiParent = this;
            frmBTH.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSKhoa DSSV = new frmDSKhoa();
            DSSV.MdiParent = this;
            DSSV.Show();
           
        }

        private void xemĐiểmTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemtheokhoa dtk = new frmDiemtheokhoa();
            dtk.MdiParent = this;
            dtk.Show();
        }
        
        private List<string> List_per()
        {
            string idper = UID;
            List<string> termlist = new List<string>();
            string connString = @"Data Source=MRROBOT\SQLEXPRESS;Initial Catalog=QuanLiDiemSV;Persist Security Info=True;User ID=sa;Password=123";
            SqlConnection con = new SqlConnection(connString);    
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Phanquyen WHERE id_per ='" + idper + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        termlist.Add(dr["code_action"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("có lỗi xảy ra");
            }
            finally
            {
                con.Close();
            }
            return termlist;
        }

        private Boolean checkper(string code)
        {
            Boolean check = false;
            foreach (string item in list_detail)
            {
                if (item == code)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            return check;

        }

        private void danhSáchKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListKhoa lisKhoa = new ListKhoa();
            lisKhoa.MdiParent = this;
            lisKhoa.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListLop lisLop = new ListLop();
            lisLop.MdiParent = this;
            lisLop.Show();
        }

        private void danhSáchKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListKhoaHoc lisKhoaHoc = new ListKhoaHoc();
            lisKhoaHoc.MdiParent = this;
            lisKhoaHoc.Show();
        }

        private void danhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListMonHoc lisMon = new ListMonHoc();
            lisMon.MdiParent = this;
            lisMon.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListHocKy lisHK = new ListHocKy();
            lisHK.MdiParent = this;
            lisHK.Show();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        

        
    }
}
