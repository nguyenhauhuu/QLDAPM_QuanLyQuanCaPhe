using ClosedXML.Excel;
using QuanLyQuanCaPhe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmThucUong : Form
    {
       
        public frmThucUong()
        {
            InitializeComponent();
            
        }

        private void LayDanhMucVaoComboBox()
        {
            

        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenThucUong.Enabled = giaTri;
            cboDanhMuc.Enabled = giaTri;
            numGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmThucUong_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenThucUong.Text = "";
            txtID.Text = "";
            txtTenThucUong.Focus();
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
            frmThucUong_Load(sender, e);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
