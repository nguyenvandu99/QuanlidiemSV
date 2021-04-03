namespace Quanlidiemsinhvien
{
    partial class frmDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMaMH = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMonHP = new System.Windows.Forms.ComboBox();
            this.cboHocky = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDiem = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMaMH);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboMonHP);
            this.groupBox1.Controls.Add(this.cboHocky);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(308, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1412, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textMaMH
            // 
            this.textMaMH.AutoSize = true;
            this.textMaMH.Location = new System.Drawing.Point(363, 131);
            this.textMaMH.Name = "textMaMH";
            this.textMaMH.Size = new System.Drawing.Size(25, 13);
            this.textMaMH.TabIndex = 33;
            this.textMaMH.Text = "Null";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(351, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 30);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Cập nhập";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Môn học phần :";
            // 
            // cboMonHP
            // 
            this.cboMonHP.FormattingEnabled = true;
            this.cboMonHP.Location = new System.Drawing.Point(155, 131);
            this.cboMonHP.Name = "cboMonHP";
            this.cboMonHP.Size = new System.Drawing.Size(144, 21);
            this.cboMonHP.TabIndex = 6;
            this.cboMonHP.SelectedIndexChanged += new System.EventHandler(this.cboMonHP_SelectedIndexChanged);
            // 
            // cboHocky
            // 
            this.cboHocky.FormattingEnabled = true;
            this.cboHocky.Location = new System.Drawing.Point(6, 62);
            this.cboHocky.Name = "cboHocky";
            this.cboHocky.Size = new System.Drawing.Size(144, 21);
            this.cboHocky.TabIndex = 5;
            this.cboHocky.SelectedIndexChanged += new System.EventHandler(this.cboHocky_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(6, 130);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(144, 21);
            this.cboLop.TabIndex = 4;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬP ĐIỂM HỌC PHẦN,ĐIỂM THI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(671, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 36);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgDiem
            // 
            this.dtgDiem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.NgaySinh,
            this.DiemKT1,
            this.DiemKT2,
            this.Diemthi});
            this.dtgDiem.Location = new System.Drawing.Point(351, 203);
            this.dtgDiem.Name = "dtgDiem";
            this.dtgDiem.Size = new System.Drawing.Size(1471, 846);
            this.dtgDiem.TabIndex = 2;
            this.dtgDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiem_CellEndEdit);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Họ tên";
            this.TenSV.Name = "TenSV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiemKT1
            // 
            this.DiemKT1.DataPropertyName = "DiemKT1";
            this.DiemKT1.HeaderText = "Điểm kiểm tra số 1";
            this.DiemKT1.Name = "DiemKT1";
            // 
            // DiemKT2
            // 
            this.DiemKT2.DataPropertyName = "DiemKT2";
            this.DiemKT2.HeaderText = "Điểm kiểm tra số 2";
            this.DiemKT2.Name = "DiemKT2";
            // 
            // Diemthi
            // 
            this.Diemthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diemthi.DataPropertyName = "Diemthi";
            this.Diemthi.HeaderText = "Điểm thi";
            this.Diemthi.Name = "Diemthi";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.dtgDiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDiem";
            this.Text = "Cập nhập học kỳ,môn thi,điểm học phần";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiem_FormClosing);
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMonHP;
        private System.Windows.Forms.ComboBox cboHocky;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtgDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemthi;
        private System.Windows.Forms.Label textMaMH;
    }
}