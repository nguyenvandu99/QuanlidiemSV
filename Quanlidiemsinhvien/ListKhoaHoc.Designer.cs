
namespace Quanlidiemsinhvien
{
    partial class ListKhoaHoc
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
            this.DsKhoaHoc = new System.Windows.Forms.DataGridView();
            this.MaKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DsKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // DsKhoaHoc
            // 
            this.DsKhoaHoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DsKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoaHoc,
            this.TenKhoaHoc});
            this.DsKhoaHoc.Location = new System.Drawing.Point(12, 29);
            this.DsKhoaHoc.Name = "DsKhoaHoc";
            this.DsKhoaHoc.Size = new System.Drawing.Size(1900, 1002);
            this.DsKhoaHoc.TabIndex = 3;
            // 
            // MaKhoaHoc
            // 
            this.MaKhoaHoc.DataPropertyName = "MaKhoaHoc";
            this.MaKhoaHoc.HeaderText = "Mã Khóa Học";
            this.MaKhoaHoc.Name = "MaKhoaHoc";
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoaHoc.DataPropertyName = "TenKhoaHoc";
            this.TenKhoaHoc.HeaderText = "Tên Khóa Học";
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            // 
            // ListKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.DsKhoaHoc);
            this.Name = "ListKhoaHoc";
            this.Text = "ListKhoaHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListKhoaHoc_FormClosing);
            this.Load += new System.EventHandler(this.ListKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsKhoaHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DsKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaHoc;
    }
}