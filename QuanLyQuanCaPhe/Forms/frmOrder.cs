using DocumentFormat.OpenXml.Office2010.Excel;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCaPhe.Data.HoaDonChiTiet;
using static QuanLyQuanCaPhe.Reports.QLQCPDataset;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmOrder : Form
    {
        
        public frmOrder(int maTaiKhoan)
        {
          
        }

        public void BatTatChucNang()
        {
            
        }
        public void LayDanhMucVaoComboBox()
        {
            cboDanhMuc.DataSource = context.DanhMuc.ToList();
            cboDanhMuc.ValueMember = "ID";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }
        public void LayBanVaoComboBox()
        {
            
        }
        public void LoadDanhSachBan()
        {
            

        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {
            
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
        }

        private void frmChucNang_Activated(object sender, EventArgs e)
        {
            frmChucNang_Load(sender, e);
        }
    }
}
