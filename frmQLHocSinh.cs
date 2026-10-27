using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyHocSinh
{
    public partial class frmQLHocSinh : Form
    {
        private bool _dangNap;            // chặn sự kiện khi đang nạp dữ liệu vào control
        private string _maHSDangChon;     // học sinh đang chọn trong lưới (null = đang nhập mới)

        public frmQLHocSinh()
        {
            InitializeComponent();
        }

        // =====================================================================
        //  KHỞI TẠO / TẢI DỮ LIỆU
        // =====================================================================

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            try
            {
                NapLop();
                NapHocSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgvHocSinh.AutoGenerateColumns = false;
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.AllowUserToDeleteRows = false;
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.MultiSelect = false;
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocSinh.RowHeadersVisible = false;
            dgvHocSinh.Columns.Clear();

            dgvHocSinh.Columns.Add(CreateColumn("MaHS", "Mã HS", 80));
            dgvHocSinh.Columns.Add(CreateColumn("TenHS", "Tên học sinh", 180));
            dgvHocSinh.Columns.Add(CreateColumn("NgaySinh", "Ngày sinh", 90, "dd/MM/yyyy"));
            dgvHocSinh.Columns.Add(CreateColumn("DiaChi", "Địa chỉ", 150));
            dgvHocSinh.Columns.Add(CreateColumn("DTB", "Điểm TB", 70, "0.0#"));
            dgvHocSinh.Columns.Add(CreateColumn("TenLop", "Lớp", 150));
            dgvHocSinh.Columns[dgvHocSinh.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private static DataGridViewTextBoxColumn CreateColumn(string property, string header, int width, string format = null)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = property;
            col.HeaderText = header;
            col.Width = width;
            if (format != null) col.DefaultCellStyle.Format = format;
            return col;
        }

        // Nạp danh sách lớp cho 2 combo (mỗi combo một DataTable riêng để không chọn chung).
        private void NapLop()
        {
            _dangNap = true;

            DataTable dtLoc = Db.Query("SELECT MaLop, TenLop FROM Lop ORDER BY MaLop");
            DataRow tatCa = dtLoc.NewRow();
            tatCa["MaLop"] = "";
            tatCa["TenLop"] = "-- Tất cả --";
            dtLoc.Rows.InsertAt(tatCa, 0);
            cboLocLop.DataSource = dtLoc;
            cboLocLop.DisplayMember = "TenLop";
            cboLocLop.ValueMember = "MaLop";

            cboLop.DataSource = Db.Query("SELECT MaLop, TenLop FROM Lop ORDER BY MaLop");
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            _dangNap = false;
        }

        // Nạp học sinh theo lớp đang lọc + từ khóa tên.
        private void NapHocSinh()
        {
            string sql =
                "SELECT hs.MaHS, hs.TenHS, hs.NgaySinh, hs.DiaChi, hs.DTB, hs.MaLop, l.TenLop " +
                "FROM HocSinh hs LEFT JOIN Lop l ON l.MaLop = hs.MaLop " +
                "WHERE hs.TenHS LIKE @Ten";
            var ps = new System.Collections.Generic.List<SqlParameter>
            {
                new SqlParameter("@Ten", "%" + txtTuKhoa.Text.Trim() + "%")
            };

            string maLop = cboLocLop.SelectedValue as string;
            if (!string.IsNullOrEmpty(maLop))
            {
                sql += " AND hs.MaLop = @MaLop";
                ps.Add(new SqlParameter("@MaLop", maLop));
            }
            sql += " ORDER BY hs.MaHS";

            _dangNap = true;
            dgvHocSinh.DataSource = Db.Query(sql, ps.ToArray());
            dgvHocSinh.ClearSelection();
            _dangNap = false;

            LamMoiForm();
        }

        private void cboLocLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try { NapHocSinh(); }
            catch (Exception ex) { BaoLoi("Không tải được danh sách học sinh", ex); }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try { NapHocSinh(); }
            catch (Exception ex) { BaoLoi("Tìm kiếm thất bại", ex); }
        }

        // Chọn dòng trong lưới -> đổ lên các ô nhập.
        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (_dangNap || dgvHocSinh.CurrentRow == null || !dgvHocSinh.CurrentRow.Selected) return;

            DataRow row = ((DataRowView)dgvHocSinh.CurrentRow.DataBoundItem).Row;

            _maHSDangChon = row["MaHS"].ToString();
            txtMaHS.Text = _maHSDangChon;
            txtMaHS.ReadOnly = true; // không cho đổi khóa chính khi sửa
            txtTenHS.Text = row["TenHS"].ToString();
            txtDiaChi.Text = row["DiaChi"] == DBNull.Value ? "" : row["DiaChi"].ToString();
            txtDTB.Text = row["DTB"] == DBNull.Value ? "" : Convert.ToSingle(row["DTB"]).ToString("0.0#");

            if (row["NgaySinh"] == DBNull.Value)
            {
                dtpNgaySinh.Checked = false;
            }
            else
            {
                dtpNgaySinh.Value = Convert.ToDateTime(row["NgaySinh"]);
                dtpNgaySinh.Checked = true;
            }

            if (row["MaLop"] == DBNull.Value) cboLop.SelectedIndex = -1;
            else cboLop.SelectedValue = row["MaLop"].ToString();
        }

        private void LamMoiForm()
        {
            _maHSDangChon = null;
            txtMaHS.Clear();
            txtMaHS.ReadOnly = false;
            txtTenHS.Clear();
            txtDiaChi.Clear();
            txtDTB.Clear();
            dtpNgaySinh.Value = new DateTime(2007, 1, 1);
            dtpNgaySinh.Checked = false;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            dgvHocSinh.ClearSelection();
            txtMaHS.Focus();
        }

        // =====================================================================
        //  KIỂM TRA DỮ LIỆU
        // =====================================================================

        // Đọc & kiểm tra các ô nhập. Trả về false (và đã báo lỗi) nếu không hợp lệ.
        private bool DocDuLieu(out DateTime? ngaySinh, out float? dtb)
        {
            ngaySinh = null;
            dtb = null;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
                return Loi("Vui lòng nhập mã học sinh!", txtMaHS);
            if (string.IsNullOrWhiteSpace(txtTenHS.Text))
                return Loi("Vui lòng nhập tên học sinh!", txtTenHS);
            if (cboLop.SelectedValue == null)
                return Loi("Vui lòng chọn lớp!", cboLop);

            string s = txtDTB.Text.Trim().Replace(',', '.'); // chấp nhận cả 8,5 và 8.5
            if (s.Length > 0)
            {
                if (!float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out float d) || d < 0 || d > 10)
                    return Loi("Điểm trung bình phải là số từ 0 đến 10!", txtDTB);
                dtb = d;
            }

            if (dtpNgaySinh.Checked)
            {
                if (dtpNgaySinh.Value.Date > DateTime.Today)
                    return Loi("Ngày sinh không được ở tương lai!", dtpNgaySinh);
                ngaySinh = dtpNgaySinh.Value.Date;
            }
            return true;
        }

        private static bool Loi(string message, Control focus)
        {
            MessageBox.Show(message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focus.Focus();
            return false;
        }

        private static void BaoLoi(string title, Exception ex)
        {
            MessageBox.Show(title + ":\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private SqlParameter[] TaoThamSo(string maHS, DateTime? ngaySinh, float? dtb)
        {
            return new[]
            {
                new SqlParameter("@MaHS", maHS),
                new SqlParameter("@TenHS", txtTenHS.Text.Trim()),
                new SqlParameter("@NgaySinh", System.Data.SqlDbType.DateTime) { Value = (object)ngaySinh ?? DBNull.Value },
                new SqlParameter("@DiaChi", string.IsNullOrWhiteSpace(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text.Trim()),
                new SqlParameter("@DTB", System.Data.SqlDbType.Real) { Value = (object)dtb ?? DBNull.Value },
                new SqlParameter("@MaLop", cboLop.SelectedValue.ToString())
            };
        }

        // =====================================================================
        //  THÊM / SỬA / XÓA
        // =====================================================================

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DocDuLieu(out DateTime? ngaySinh, out float? dtb)) return;
            string maHS = txtMaHS.Text.Trim();

            try
            {
                int tonTai = (int)Db.Scalar("SELECT COUNT(*) FROM HocSinh WHERE MaHS = @MaHS",
                    new SqlParameter("@MaHS", maHS));
                if (tonTai > 0)
                {
                    Loi("Mã học sinh đã tồn tại!", txtMaHS);
                    return;
                }

                Db.Execute(
                    "INSERT INTO HocSinh (MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) " +
                    "VALUES (@MaHS, @TenHS, @NgaySinh, @DiaChi, @DTB, @MaLop)",
                    TaoThamSo(maHS, ngaySinh, dtb));

                NapHocSinh();
                MessageBox.Show("Thêm học sinh thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { BaoLoi("Thêm học sinh thất bại", ex); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maHSDangChon == null)
            {
                MessageBox.Show("Hãy chọn một học sinh trong danh sách để sửa!", "Chưa chọn học sinh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!DocDuLieu(out DateTime? ngaySinh, out float? dtb)) return;

            try
            {
                Db.Execute(
                    "UPDATE HocSinh SET TenHS = @TenHS, NgaySinh = @NgaySinh, DiaChi = @DiaChi, " +
                    "DTB = @DTB, MaLop = @MaLop WHERE MaHS = @MaHS",
                    TaoThamSo(_maHSDangChon, ngaySinh, dtb));

                NapHocSinh();
                MessageBox.Show("Cập nhật học sinh thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { BaoLoi("Cập nhật học sinh thất bại", ex); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maHSDangChon == null)
            {
                MessageBox.Show("Hãy chọn một học sinh trong danh sách để xóa!", "Chưa chọn học sinh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Xóa học sinh \"{txtTenHS.Text}\" ({_maHSDangChon})?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Db.Execute("DELETE FROM HocSinh WHERE MaHS = @MaHS", new SqlParameter("@MaHS", _maHSDangChon));

                NapHocSinh();
                MessageBox.Show("Đã xóa học sinh!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { BaoLoi("Xóa học sinh thất bại", ex); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { LamMoiForm(); }
        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}
