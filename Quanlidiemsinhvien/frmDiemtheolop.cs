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
    public partial class frmDiemtheolop : Form
    {
        public frmDiemtheolop()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        Xuly xl = new Xuly();
        private void frmBangTongHop_Load(object sender, EventArgs e)
        {
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
            cboLop.DataSource = dt.Lop_SelectAll();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewSV.Nodes.Clear();
            foreach (var r in dt.SinhVien_SelectMaLop(cboLop.SelectedValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.TenSV;
                treeViewSV.Nodes.Add(node);
            }
            treeViewSV.ExpandAll();
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
                lbnNgaysinh.Text = Convert.ToDateTime(r.NgaySinh).ToString("dd-MM-yyyy");
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
            Double t = Math.Round(tong / SoTinChi,2);
            dtgDiem.DataSource = table;
            lbnTB.Text = t.ToString();
            lbnXL.Text = xl.xlTK(t);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {   //Khởi tạo excel
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khởi tạo WorkBook
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // đổ dữ liệu vào sheet
            worksheet.Cells[1, 2] =  "TRƯỜNG ĐẠI HỌC ";
            worksheet.Cells[2, 1] = "TÀI NGUYÊN VÀ MÔI TRƯỜNG HÀ NỘI";
            worksheet.Cells[1, 5] = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM ";
            worksheet.Cells[2, 5] = "Độc lập-Tự do-Hạnh Phúc";
            worksheet.Range["E2", "E2"].HorizontalAlignment = 3;
            worksheet.Cells[4, 3] = "BẢNG TỔNG HỢP CHI TIẾT ĐIỂM SINH VIÊN";
            worksheet.Cells[7, 2] = "Mã SV : " + lbnMaSV.Text;
            worksheet.Cells[8, 2] = "Tên SV : " + lbnTenSV.Text;
            worksheet.Cells[9, 2] = "Ngày sinh : " + lbnNgaysinh.Text;
            worksheet.Cells[10, 2] = "Giới tính : " + lbnGioitinh.Text;
            worksheet.Cells[11, 2] = "Quê quán : " + lbnQuequan.Text;
            int mon = dtgDiem.RowCount - 1;
            worksheet.Cells[12, 2] = "Trung bình toàn khóa :" + lbnTB.Text;
            worksheet.Cells[13, 2] = "Xếp loại toàn khóa : " + lbnXL.Text;
            worksheet.Cells[14, 1] = "STT";
            worksheet.Cells[14, 2] = "Mã Môn Học";
            worksheet.Cells[14, 3] = "Tên Môn";
            worksheet.Cells[14, 4] = "Số Tín Chỉ";
            worksheet.Cells[14, 5] = "Điểm HP";
            worksheet.Cells[14, 6] = "Điểm Chữ";
            worksheet.Cells[14, 7] = "Điểm Số";
            for (int i = 0; i < dtgDiem.RowCount - 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 15, 1] = i + 1;
                    worksheet.Cells[i + 15, j + 2] = dtgDiem.Rows[i].Cells[j].Value;
                }
            }

            //Định dạng trang:
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            worksheet.PageSetup.HeaderMargin = 0;
            worksheet.PageSetup.FooterMargin = 0;
            //Đinh dạng Cột
            worksheet.Range["A1"].ColumnWidth = 100;
            worksheet.Range["A2"].ColumnWidth = 8.25;
            worksheet.Range["B2"].ColumnWidth = 25;
            worksheet.Range["C2"].ColumnWidth = 25;
            worksheet.Range["D2"].ColumnWidth = 15;
            worksheet.Range["E2"].ColumnWidth = 15;
            worksheet.Range["F2"].ColumnWidth = 15;
            worksheet.Range["G2"].ColumnWidth = 15;
            //Định dạng font chữ
            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G1"].Font.Size = 12;
            

            worksheet.Range["A2", "G100"].Font.Size = 12;
            //worksheet.Range["A1","G100"].MergeCells = true;
            //worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A14", "G14"].Font.Bold = true;
            //Kẻ bảng điểm
            worksheet.Range["A14", "G" + (mon + 14)].Borders.LineStyle = 1;
            //Chỉnh chữ ra giữa cột
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A14", "G14"].HorizontalAlignment = 3;
            worksheet.Range["A15", "A" + (mon + 14)].HorizontalAlignment = 3;
            worksheet.Range["B15", "B" + (mon + 14)].HorizontalAlignment = 3;
            worksheet.Range["D15", "D" + (mon + 14)].HorizontalAlignment = 3;
            worksheet.Range["E15", "E" + (mon + 14)].HorizontalAlignment = 3;
            worksheet.Range["F15", "F" + (mon + 14)].HorizontalAlignment = 3;
            worksheet.Range["G15", "G" + (mon + 14)].HorizontalAlignment = 3;



        }

        private void lbnMaSV_Click(object sender, EventArgs e)
        {

        }

        private void frmDiemtheolop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
    }
}
