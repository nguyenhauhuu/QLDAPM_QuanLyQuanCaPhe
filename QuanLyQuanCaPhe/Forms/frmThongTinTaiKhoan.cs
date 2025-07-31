using QuanLyQuanCaPhe.Data;
using SlugGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmThongTinTaiKhoan : Form
    {
        


        public frmThongTinTaiKhoan(int idTaiKhoan)
        {
            InitializeComponent();
           
        }
        private void LoadThongTinTaiKhoan()
        {
           
        }
        private void BatTatChucNang(bool giatri)
        {
            txtTenDayDu.Enabled = giatri;
            dtpNgaySinh.Enabled = giatri;
            picHinhAnh.Enabled = giatri;
            btnSua.Enabled = !giatri;
            btnLuu.Enabled = giatri;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            txtTenDayDu.Focus();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadThongTinTaiKhoan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCapNhatMatKhau_Click(object sender, EventArgs e)
        {
            
        }
    }
}
