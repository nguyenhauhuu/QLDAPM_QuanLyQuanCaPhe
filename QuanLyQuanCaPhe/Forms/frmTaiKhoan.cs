using ClosedXML.Excel;
using QuanLyQuanCaPhe.Data;
using SlugGenerator;
using System.Configuration;
using System.Data;
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtTenDayDu.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            cboQuyenTruyCap.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            BatTatChucNang(true);
           
            txtTenDangNhap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmTaiKhoan_Load(sender, e);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;

        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKhoiPhucMatKhau_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
