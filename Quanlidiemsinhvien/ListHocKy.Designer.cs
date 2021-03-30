
namespace Quanlidiemsinhvien
{
    partial class ListHocKy
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
            this.DsHocKy = new System.Windows.Forms.DataGridView();
            this.MaHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DsHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // DsHocKy
            // 
            this.DsHocKy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DsHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHK,
            this.TenHK});
            this.DsHocKy.Location = new System.Drawing.Point(12, 29);
            this.DsHocKy.Name = "DsHocKy";
            this.DsHocKy.Size = new System.Drawing.Size(1900, 1002);
            this.DsHocKy.TabIndex = 4;
            // 
            // MaHK
            // 
            this.MaHK.DataPropertyName = "MaHK";
            this.MaHK.HeaderText = "MãHọc Kỳ";
            this.MaHK.Name = "MaHK";
            // 
            // TenHK
            // 
            this.TenHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHK.DataPropertyName = "TenHK";
            this.TenHK.HeaderText = "Tên Học Kỳ";
            this.TenHK.Name = "TenHK";
            // 
            // ListHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.DsHocKy);
            this.Name = "ListHocKy";
            this.Text = "ListHocKy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListHocKy_FormClosing);
            this.Load += new System.EventHandler(this.ListHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsHocKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DsHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHK;
    }
}