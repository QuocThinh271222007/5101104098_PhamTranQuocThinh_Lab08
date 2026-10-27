using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmMain : Form
    {
        private bool _daDangNhap;

        public frmMain()
        {
            InitializeComponent();
            CapNhatTrangThai();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            DangNhap();
        }

        // =====================================================================
        //  ĐĂNG NHẬP / ĐĂNG XUẤT
        // =====================================================================

        private void DangNhap()
        {
            using (var f = new frmLogin())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    _daDangNhap = true;
                    CapNhatTrangThai();
                }
                else if (!_daDangNhap)
                {
                    Close(); // hủy đăng nhập lần đầu -> thoát chương trình
                }
            }
        }

        private void DangXuat()
        {
            _daDangNhap = false;
            foreach (Form child in MdiChildren) child.Close();
            CapNhatTrangThai();
            DangNhap();
        }

        // Khóa/mở menu theo trạng thái đăng nhập.
        private void CapNhatTrangThai()
        {
            mnuDanhMuc.Enabled = _daDangNhap;
            mnuCuaSo.Enabled = _daDangNhap;
            mnuDangNhap.Enabled = !_daDangNhap;
            mnuDangXuat.Enabled = _daDangNhap;
            lblTrangThai.Text = _daDangNhap ? "Đã đăng nhập: admin" : "Chưa đăng nhập";
        }

        // =====================================================================
        //  MDI
        // =====================================================================

        // Mỗi loại form con chỉ mở một cửa sổ; nếu đã mở thì kích hoạt lại.
        private void MoFormCon<T>() where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    return;
                }
            }
            var child = new T();
            child.MdiParent = this;
            child.Show();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e) { DangNhap(); }
        private void mnuDangXuat_Click(object sender, EventArgs e) { DangXuat(); }
        private void mnuThoat_Click(object sender, EventArgs e) { Close(); }

        private void mnuLop_Click(object sender, EventArgs e) { MoFormCon<frmQLLop>(); }
        private void mnuHocSinh_Click(object sender, EventArgs e) { MoFormCon<frmQLHocSinh>(); }

        private void mnuCascade_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.Cascade); }
        private void mnuTileVertical_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileVertical); }
        private void mnuTileHorizontal_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileHorizontal); }
    }
}
