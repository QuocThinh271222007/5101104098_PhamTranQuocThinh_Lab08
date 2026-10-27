using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmLogin : Form
    {
        // Tài khoản cố định cho bài thực hành (chưa có bảng tài khoản trong DB).
        private const string TaiKhoanMau = "admin";
        private const string MatKhauMau = "123456";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == TaiKhoanMau && txtMatKhau.Text == MatKhauMau)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMatKhau.Clear();
            txtMatKhau.Focus();
        }
    }
}
