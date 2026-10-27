using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyHocSinh
{
    public partial class frmQLLop : Form
    {
        // Chế độ sửa/xóa: mã lớp đang chọn trong ListView (null = đang nhập lớp mới).
        private string _maLopDangChon;

        public frmQLLop()
        {
            InitializeComponent();
        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {
            cboKieuXem.Items.AddRange(new object[]
            {
                View.Details, View.List, View.SmallIcon, View.LargeIcon, View.Tile
            });
            cboKieuXem.SelectedItem = View.Details;
            NapLop();
        }

        // =====================================================================
        //  TẢI DỮ LIỆU
        // =====================================================================

        private void NapLop()
        {
            try
            {
                DataTable dt = Db.Query("SELECT MaLop, TenLop, SiSo FROM Lop ORDER BY MaLop");

                lvLop.BeginUpdate();
                lvLop.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row["MaLop"].ToString());
                    item.SubItems.Add(row["TenLop"].ToString());
                    item.SubItems.Add(row["SiSo"] == DBNull.Value ? "" : row["SiSo"].ToString());
                    lvLop.Items.Add(item);
                }
                lvLop.EndUpdate();

                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách lớp:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboKieuXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKieuXem.SelectedItem is View v) lvLop.View = v;
        }

        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLop.SelectedItems.Count == 0) return;

            ListViewItem item = lvLop.SelectedItems[0];
            _maLopDangChon = item.SubItems[0].Text;
            txtMaLop.Text = item.SubItems[0].Text;
            txtTenLop.Text = item.SubItems[1].Text;
            txtSiSo.Text = item.SubItems[2].Text;
            txtMaLop.ReadOnly = true; // khóa mã lớp khi sửa
        }

        private void LamMoiForm()
        {
            _maLopDangChon = null;
            lvLop.SelectedItems.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
            txtMaLop.ReadOnly = false;
            txtMaLop.Focus();
        }

        // =====================================================================
        //  NGHIỆP VỤ
        // =====================================================================

        // Kiểm tra tên lớp + sĩ số (sĩ số không bắt buộc, phải là số nguyên không âm).
        private bool DocDuLieu(out short? siSo)
        {
            siSo = null;

            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return false;
            }

            string s = txtSiSo.Text.Trim();
            if (s.Length > 0)
            {
                if (!short.TryParse(s, out short v) || v < 0)
                {
                    MessageBox.Show("Sĩ số phải là số nguyên không âm!", "Sai dữ liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSiSo.Focus();
                    return false;
                }
                siSo = v;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            if (maLop.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (!DocDuLieu(out short? siSo)) return;

            try
            {
                int tonTai = (int)Db.Scalar("SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop",
                    new SqlParameter("@MaLop", maLop));
                if (tonTai > 0)
                {
                    MessageBox.Show("Mã lớp đã tồn tại!", "Trùng mã",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLop.Focus();
                    return;
                }

                Db.Execute("INSERT INTO Lop (MaLop, TenLop, SiSo) VALUES (@MaLop, @TenLop, @SiSo)",
                    new SqlParameter("@MaLop", maLop),
                    new SqlParameter("@TenLop", txtTenLop.Text.Trim()),
                    new SqlParameter("@SiSo", (object)siSo ?? DBNull.Value));

                NapLop();
                MessageBox.Show("Thêm lớp thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lớp thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maLopDangChon == null)
            {
                MessageBox.Show("Hãy chọn một lớp trong danh sách để sửa!", "Chưa chọn lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!DocDuLieu(out short? siSo)) return;

            try
            {
                Db.Execute("UPDATE Lop SET TenLop = @TenLop, SiSo = @SiSo WHERE MaLop = @MaLop",
                    new SqlParameter("@MaLop", _maLopDangChon),
                    new SqlParameter("@TenLop", txtTenLop.Text.Trim()),
                    new SqlParameter("@SiSo", (object)siSo ?? DBNull.Value));

                NapLop();
                MessageBox.Show("Cập nhật lớp thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật lớp thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maLopDangChon == null)
            {
                MessageBox.Show("Hãy chọn một lớp trong danh sách để xóa!", "Chưa chọn lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Xóa lớp \"{_maLopDangChon}\"?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Db.Execute("DELETE FROM Lop WHERE MaLop = @MaLop",
                    new SqlParameter("@MaLop", _maLopDangChon));

                NapLop();
                MessageBox.Show("Đã xóa lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 547) // vi phạm khóa ngoại
            {
                MessageBox.Show("Không thể xóa: lớp này vẫn còn học sinh.\nHãy chuyển hoặc xóa học sinh trước.",
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lớp thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { LamMoiForm(); }
        private void btnThoat_Click(object sender, EventArgs e) { Close(); }
    }
}
