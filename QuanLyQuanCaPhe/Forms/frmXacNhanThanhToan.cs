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

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmXacNhanThanhToan : Form
    {
       
        public frmXacNhanThanhToan()
        {
            InitializeComponent();
        }
        public frmXacNhanThanhToan(int maHoaDon)
        {
            
        }

        private void frmXacNhanThanhToan_Load(object sender, EventArgs e)
        {
            
        }

        private void cboHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTienKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(sender, e);
            }
        }
    }
}
