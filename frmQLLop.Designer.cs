namespace QuanLyHocSinh
{
    partial class frmQLLop
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblKieuXem = new System.Windows.Forms.Label();
            this.cboKieuXem = new System.Windows.Forms.ComboBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.colTenLop = new System.Windows.Forms.ColumnHeader();
            this.colSiSo = new System.Windows.Forms.ColumnHeader();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(12, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(596, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ LỚP";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblKieuXem
            //
            this.lblKieuXem.Location = new System.Drawing.Point(12, 54);
            this.lblKieuXem.Name = "lblKieuXem";
            this.lblKieuXem.Size = new System.Drawing.Size(65, 23);
            this.lblKieuXem.TabIndex = 1;
            this.lblKieuXem.Text = "Kiểu xem:";
            //
            // cboKieuXem
            //
            this.cboKieuXem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKieuXem.Location = new System.Drawing.Point(83, 51);
            this.cboKieuXem.Name = "cboKieuXem";
            this.cboKieuXem.Size = new System.Drawing.Size(150, 23);
            this.cboKieuXem.TabIndex = 2;
            this.cboKieuXem.SelectedIndexChanged += new System.EventHandler(this.cboKieuXem_SelectedIndexChanged);
            //
            // lvLop
            //
            this.lvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLop,
            this.colTenLop,
            this.colSiSo});
            this.lvLop.FullRowSelect = true;
            this.lvLop.GridLines = true;
            this.lvLop.HideSelection = false;
            this.lvLop.Location = new System.Drawing.Point(12, 85);
            this.lvLop.MultiSelect = false;
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(596, 170);
            this.lvLop.TabIndex = 3;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            this.lvLop.SelectedIndexChanged += new System.EventHandler(this.lvLop_SelectedIndexChanged);
            //
            // colMaLop
            //
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 120;
            //
            // colTenLop
            //
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 330;
            //
            // colSiSo
            //
            this.colSiSo.Text = "Sĩ số";
            this.colSiSo.Width = 90;
            //
            // grbThongTin
            //
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.Controls.Add(this.lblMaLop);
            this.grbThongTin.Controls.Add(this.txtMaLop);
            this.grbThongTin.Controls.Add(this.lblTenLop);
            this.grbThongTin.Controls.Add(this.txtTenLop);
            this.grbThongTin.Controls.Add(this.lblSiSo);
            this.grbThongTin.Controls.Add(this.txtSiSo);
            this.grbThongTin.Location = new System.Drawing.Point(12, 265);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(596, 110);
            this.grbThongTin.TabIndex = 4;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin lớp";
            //
            // lblMaLop
            //
            this.lblMaLop.Location = new System.Drawing.Point(15, 28);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(70, 23);
            this.lblMaLop.Text = "Mã lớp:";
            //
            // txtMaLop
            //
            this.txtMaLop.Location = new System.Drawing.Point(95, 25);
            this.txtMaLop.MaxLength = 20;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(150, 23);
            this.txtMaLop.TabIndex = 0;
            //
            // lblTenLop
            //
            this.lblTenLop.Location = new System.Drawing.Point(15, 62);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(70, 23);
            this.lblTenLop.Text = "Tên lớp:";
            //
            // txtTenLop
            //
            this.txtTenLop.Location = new System.Drawing.Point(95, 59);
            this.txtTenLop.MaxLength = 100;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(280, 23);
            this.txtTenLop.TabIndex = 1;
            //
            // lblSiSo
            //
            this.lblSiSo.Location = new System.Drawing.Point(400, 28);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(45, 23);
            this.lblSiSo.Text = "Sĩ số:";
            //
            // txtSiSo
            //
            this.txtSiSo.Location = new System.Drawing.Point(451, 25);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(120, 23);
            this.txtSiSo.TabIndex = 2;
            //
            // btnThem
            //
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(12, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(124, 388);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(236, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLamMoi.Location = new System.Drawing.Point(348, 388);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // btnThoat
            //
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(508, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            //
            // frmQLLop
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 435);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblKieuXem);
            this.Controls.Add(this.cboKieuXem);
            this.Controls.Add(this.lvLop);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmQLLop";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.frmQLLop_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblKieuXem;
        private System.Windows.Forms.ComboBox cboKieuXem;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.ColumnHeader colSiSo;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}
