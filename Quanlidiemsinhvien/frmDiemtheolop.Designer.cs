namespace Quanlidiemsinhvien
{
    partial class frmDiemtheolop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemtheolop));
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbnMaSV = new System.Windows.Forms.Label();
            this.lbnTenSV = new System.Windows.Forms.Label();
            this.lbnNgaysinh = new System.Windows.Forms.Label();
            this.lbnQuequan = new System.Windows.Forms.Label();
            this.lbnGioitinh = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbnTB = new System.Windows.Forms.Label();
            this.lbnXL = new System.Windows.Forms.Label();
            this.treeViewSV = new System.Windows.Forms.TreeView();
            this.dtgDiem = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp :";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(135, 56);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(281, 21);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(961, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "BẢNG TỔNG HỢP CHI TIẾT ĐIỂM SINH VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sinh viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(619, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(975, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quê quán :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(992, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giới tính :";
            // 
            // lbnMaSV
            // 
            this.lbnMaSV.AutoSize = true;
            this.lbnMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMaSV.Location = new System.Drawing.Point(761, 69);
            this.lbnMaSV.Name = "lbnMaSV";
            this.lbnMaSV.Size = new System.Drawing.Size(43, 24);
            this.lbnMaSV.TabIndex = 9;
            this.lbnMaSV.Text = "Null";
            this.lbnMaSV.Click += new System.EventHandler(this.lbnMaSV_Click);
            // 
            // lbnTenSV
            // 
            this.lbnTenSV.AutoSize = true;
            this.lbnTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTenSV.Location = new System.Drawing.Point(761, 108);
            this.lbnTenSV.Name = "lbnTenSV";
            this.lbnTenSV.Size = new System.Drawing.Size(43, 24);
            this.lbnTenSV.TabIndex = 10;
            this.lbnTenSV.Text = "Null";
            // 
            // lbnNgaysinh
            // 
            this.lbnNgaysinh.AutoSize = true;
            this.lbnNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnNgaysinh.Location = new System.Drawing.Point(761, 142);
            this.lbnNgaysinh.Name = "lbnNgaysinh";
            this.lbnNgaysinh.Size = new System.Drawing.Size(43, 24);
            this.lbnNgaysinh.TabIndex = 11;
            this.lbnNgaysinh.Text = "Null";
            // 
            // lbnQuequan
            // 
            this.lbnQuequan.AutoSize = true;
            this.lbnQuequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnQuequan.Location = new System.Drawing.Point(1098, 85);
            this.lbnQuequan.Name = "lbnQuequan";
            this.lbnQuequan.Size = new System.Drawing.Size(43, 24);
            this.lbnQuequan.TabIndex = 12;
            this.lbnQuequan.Text = "Null";
            // 
            // lbnGioitinh
            // 
            this.lbnGioitinh.AutoSize = true;
            this.lbnGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnGioitinh.Location = new System.Drawing.Point(1098, 136);
            this.lbnGioitinh.Name = "lbnGioitinh";
            this.lbnGioitinh.Size = new System.Drawing.Size(43, 24);
            this.lbnGioitinh.TabIndex = 13;
            this.lbnGioitinh.Text = "Null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1307, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "TB toàn khóa :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1307, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 24);
            this.label16.TabIndex = 16;
            this.label16.Text = "XL toàn khóa :";
            // 
            // lbnTB
            // 
            this.lbnTB.AutoSize = true;
            this.lbnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTB.ForeColor = System.Drawing.Color.Maroon;
            this.lbnTB.Location = new System.Drawing.Point(1458, 85);
            this.lbnTB.Name = "lbnTB";
            this.lbnTB.Size = new System.Drawing.Size(43, 24);
            this.lbnTB.TabIndex = 17;
            this.lbnTB.Text = "Null";
            // 
            // lbnXL
            // 
            this.lbnXL.AutoSize = true;
            this.lbnXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnXL.ForeColor = System.Drawing.Color.Maroon;
            this.lbnXL.Location = new System.Drawing.Point(1459, 142);
            this.lbnXL.Name = "lbnXL";
            this.lbnXL.Size = new System.Drawing.Size(43, 24);
            this.lbnXL.TabIndex = 18;
            this.lbnXL.Text = "Null";
            // 
            // treeViewSV
            // 
            this.treeViewSV.Location = new System.Drawing.Point(37, 88);
            this.treeViewSV.Name = "treeViewSV";
            this.treeViewSV.Size = new System.Drawing.Size(382, 961);
            this.treeViewSV.TabIndex = 19;
            this.treeViewSV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSV_AfterSelect);
            this.treeViewSV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSV_NodeMouseClick);
            // 
            // dtgDiem
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoTC,
            this.DiemHP,
            this.DiemChu,
            this.DiemSo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDiem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDiem.Location = new System.Drawing.Point(425, 177);
            this.dtgDiem.Name = "dtgDiem";
            this.dtgDiem.Size = new System.Drawing.Size(1487, 872);
            this.dtgDiem.TabIndex = 20;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTC";
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.Name = "SoTC";
            this.SoTC.ReadOnly = true;
            // 
            // DiemHP
            // 
            this.DiemHP.DataPropertyName = "DiemHP";
            this.DiemHP.HeaderText = "Điểm tổng kết";
            this.DiemHP.Name = "DiemHP";
            this.DiemHP.ReadOnly = true;
            // 
            // DiemChu
            // 
            this.DiemChu.DataPropertyName = "DiemChu";
            this.DiemChu.HeaderText = "Điểm chữ";
            this.DiemChu.Name = "DiemChu";
            this.DiemChu.ReadOnly = true;
            // 
            // DiemSo
            // 
            this.DiemSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemSo.DataPropertyName = "DiemSo";
            this.DiemSo.HeaderText = "Điểm Số";
            this.DiemSo.Name = "DiemSo";
            this.DiemSo.ReadOnly = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1619, 88);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 80);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmDiemtheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dtgDiem);
            this.Controls.Add(this.treeViewSV);
            this.Controls.Add(this.lbnXL);
            this.Controls.Add(this.lbnTB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbnGioitinh);
            this.Controls.Add(this.lbnQuequan);
            this.Controls.Add(this.lbnNgaysinh);
            this.Controls.Add(this.lbnTenSV);
            this.Controls.Add(this.lbnMaSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDiemtheolop";
            this.Text = "frmXemDiemTheoLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiemtheolop_FormClosing);
            this.Load += new System.EventHandler(this.frmBangTongHop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbnMaSV;
        private System.Windows.Forms.Label lbnTenSV;
        private System.Windows.Forms.Label lbnNgaysinh;
        private System.Windows.Forms.Label lbnQuequan;
        private System.Windows.Forms.Label lbnGioitinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbnTB;
        private System.Windows.Forms.Label lbnXL;
        private System.Windows.Forms.TreeView treeViewSV;
        private System.Windows.Forms.DataGridView dtgDiem;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemSo;
    }
}