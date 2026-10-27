namespace QuanLyHocSinh
{
    partial class frmQLHocSinh
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
            this.grbLoc = new System.Windows.Forms.GroupBox();
            this.lblLocLop = new System.Windows.Forms.Label();
            this.cboLocLop = new System.Windows.Forms.ComboBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblDTB = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.grbLoc.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(12, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(796, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ HỌC SINH";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // grbLoc
            //
            this.grbLoc.Controls.Add(this.lblLocLop);
            this.grbLoc.Controls.Add(this.cboLocLop);
            this.grbLoc.Controls.Add(this.lblTuKhoa);
            this.grbLoc.Controls.Add(this.txtTuKhoa);
            this.grbLoc.Controls.Add(this.btnTim);
            this.grbLoc.Location = new System.Drawing.Point(12, 45);
            this.grbLoc.Name = "grbLoc";
            this.grbLoc.Size = new System.Drawing.Size(796, 60);
            this.grbLoc.TabIndex = 1;
            this.grbLoc.TabStop = false;
            this.grbLoc.Text = "Lọc / tìm kiếm";
            //
            // lblLocLop
            //
            this.lblLocLop.Location = new System.Drawing.Point(15, 27);
            this.lblLocLop.Name = "lblLocLop";
            this.lblLocLop.Size = new System.Drawing.Size(45, 23);
            this.lblLocLop.Text = "Lớp:";
            //
            // cboLocLop
            //
            this.cboLocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLop.Location = new System.Drawing.Point(65, 24);
            this.cboLocLop.Name = "cboLocLop";
            this.cboLocLop.Size = new System.Drawing.Size(200, 23);
            this.cboLocLop.TabIndex = 0;
            this.cboLocLop.SelectedIndexChanged += new System.EventHandler(this.cboLocLop_SelectedIndexChanged);
            //
            // lblTuKhoa
            //
            this.lblTuKhoa.Location = new System.Drawing.Point(290, 27);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(65, 23);
            this.lblTuKhoa.Text = "Tên HS:";
            //
            // txtTuKhoa
            //
            this.txtTuKhoa.Location = new System.Drawing.Point(360, 24);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(250, 23);
            this.txtTuKhoa.TabIndex = 1;
            //
            // btnTim
            //
            this.btnTim.Location = new System.Drawing.Point(630, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            //
            // grbThongTin
            //
            this.grbThongTin.Controls.Add(this.lblMaHS);
            this.grbThongTin.Controls.Add(this.txtMaHS);
            this.grbThongTin.Controls.Add(this.lblLop);
            this.grbThongTin.Controls.Add(this.cboLop);
            this.grbThongTin.Controls.Add(this.lblTenHS);
            this.grbThongTin.Controls.Add(this.txtTenHS);
            this.grbThongTin.Controls.Add(this.lblNgaySinh);
            this.grbThongTin.Controls.Add(this.dtpNgaySinh);
            this.grbThongTin.Controls.Add(this.lblDTB);
            this.grbThongTin.Controls.Add(this.txtDTB);
            this.grbThongTin.Controls.Add(this.lblDiaChi);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Location = new System.Drawing.Point(12, 115);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(796, 180);
            this.grbThongTin.TabIndex = 2;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin học sinh";
            //
            // lblMaHS
            //
            this.lblMaHS.Location = new System.Drawing.Point(15, 30);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(95, 23);
            this.lblMaHS.Text = "Mã học sinh:";
            //
            // txtMaHS
            //
            this.txtMaHS.Location = new System.Drawing.Point(120, 27);
            this.txtMaHS.MaxLength = 20;
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(160, 23);
            this.txtMaHS.TabIndex = 0;
            //
            // lblLop
            //
            this.lblLop.Location = new System.Drawing.Point(420, 30);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(45, 23);
            this.lblLop.Text = "Lớp:";
            //
            // cboLop
            //
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Location = new System.Drawing.Point(480, 27);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(290, 23);
            this.cboLop.TabIndex = 1;
            //
            // lblTenHS
            //
            this.lblTenHS.Location = new System.Drawing.Point(15, 65);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(95, 23);
            this.lblTenHS.Text = "Tên học sinh:";
            //
            // txtTenHS
            //
            this.txtTenHS.Location = new System.Drawing.Point(120, 62);
            this.txtTenHS.MaxLength = 100;
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(650, 23);
            this.txtTenHS.TabIndex = 2;
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 100);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(95, 23);
            this.lblNgaySinh.Text = "Ngày sinh:";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 97);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShowCheckBox = true;
            this.dtpNgaySinh.Size = new System.Drawing.Size(160, 23);
            this.dtpNgaySinh.TabIndex = 3;
            //
            // lblDTB
            //
            this.lblDTB.Location = new System.Drawing.Point(420, 100);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(55, 23);
            this.lblDTB.Text = "Điểm TB:";
            //
            // txtDTB
            //
            this.txtDTB.Location = new System.Drawing.Point(480, 97);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(120, 23);
            this.txtDTB.TabIndex = 4;
            //
            // lblDiaChi
            //
            this.lblDiaChi.Location = new System.Drawing.Point(15, 135);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(95, 23);
            this.lblDiaChi.Text = "Địa chỉ:";
            //
            // txtDiaChi
            //
            this.txtDiaChi.Location = new System.Drawing.Point(120, 132);
            this.txtDiaChi.MaxLength = 150;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(650, 23);
            this.txtDiaChi.TabIndex = 5;
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(12, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new System.Drawing.Point(132, 305);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(252, 305);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new System.Drawing.Point(372, 305);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 32);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(698, 305);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 32);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            //
            // lblDanhSach
            //
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.Location = new System.Drawing.Point(12, 349);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.TabIndex = 8;
            this.lblDanhSach.Text = "Danh sách học sinh";
            //
            // dgvHocSinh
            //
            this.dgvHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocSinh.Location = new System.Drawing.Point(12, 375);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(796, 235);
            this.dgvHocSinh.TabIndex = 9;
            this.dgvHocSinh.SelectionChanged += new System.EventHandler(this.dgvHocSinh_SelectionChanged);
            //
            // frmQLHocSinh
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 625);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grbLoc);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.dgvHocSinh);
            this.Name = "frmQLHocSinh";
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.frmQLHocSinh_Load);
            this.grbLoc.ResumeLayout(false);
            this.grbLoc.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbLoc;
        private System.Windows.Forms.Label lblLocLop;
        private System.Windows.Forms.ComboBox cboLocLop;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvHocSinh;
    }
}
