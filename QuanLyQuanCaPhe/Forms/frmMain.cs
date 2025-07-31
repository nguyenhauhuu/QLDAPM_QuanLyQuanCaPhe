using DocumentFormat.OpenXml.InkML;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmMain : Form
    {
        bool sidebarExpend;
        bool ThongkeBaoCaoCollapsed;
        bool QuanLyCollapsed;
        bool HeThongCollapsed;
        bool TroGiupCollapsed;

        
        public frmMain()
        {
            InitializeComponent();
        }


        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://chanhdang.com";
            Process.Start(info);
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpend)
            {
                //if sidebar is expend, minisize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpend = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpend = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            ThongKeBaoCaoTimer.Start();
        }


        private void ThongKeBaoCaoTimer_Tick(object sender, EventArgs e)
        {
            if (ThongkeBaoCaoCollapsed)
            {
                //if container is collapsed, minisize
                ThongKeBaoCaoContainer.Height -= 10;
                if (ThongKeBaoCaoContainer.Height == ThongKeBaoCaoContainer.MinimumSize.Height)
                {
                    ThongkeBaoCaoCollapsed = false;
                    ThongKeBaoCaoTimer.Stop();
                }
            }
            else
            {
                ThongKeBaoCaoContainer.Height += 10;
                if (ThongKeBaoCaoContainer.Height == ThongKeBaoCaoContainer.MaximumSize.Height)
                {
                    ThongkeBaoCaoCollapsed = true;
                    ThongKeBaoCaoTimer.Stop();
                }
            }
        }

        private void QuanLyTimer_Tick(object sender, EventArgs e)
        {
            if (QuanLyCollapsed)
            {
                //if container is collapsed, minisize
                QuanLyContainer.Height -= 10;
                if (QuanLyContainer.Height == QuanLyContainer.MinimumSize.Height)
                {
                    QuanLyCollapsed = false;
                    QuanLyTimer.Stop();
                }
            }
            else
            {
                QuanLyContainer.Height += 10;
                if (QuanLyContainer.Height == QuanLyContainer.MaximumSize.Height)
                {
                    QuanLyCollapsed = true;
                    QuanLyTimer.Stop();
                }
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLyTimer.Start();
        }

        private void HeThongTimer_Tick(object sender, EventArgs e)
        {
            if (HeThongCollapsed)
            {
                //if container is collapsed, minisize
                HeThongContainer.Height -= 10;
                if (HeThongContainer.Height == HeThongContainer.MinimumSize.Height)
                {
                    HeThongCollapsed = false;
                    HeThongTimer.Stop();
                }
            }
            else
            {
                HeThongContainer.Height += 10;
                if (HeThongContainer.Height == HeThongContainer.MaximumSize.Height)
                {
                    HeThongCollapsed = true;
                    HeThongTimer.Stop();
                }
            }
        }

        private void TroGiupTimer_Tick(object sender, EventArgs e)
        {
            if (TroGiupCollapsed)
            {
                //if container is collapsed, minisize
                TroGiupContainer.Height -= 10;
                if (TroGiupContainer.Height == TroGiupContainer.MinimumSize.Height)
                {
                    TroGiupCollapsed = false;
                    TroGiupTimer.Stop();
                }
            }
            else
            {
                TroGiupContainer.Height += 10;
                if (TroGiupContainer.Height == TroGiupContainer.MaximumSize.Height)
                {
                    TroGiupCollapsed = true;
                    TroGiupTimer.Stop();
                }
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            HeThongTimer.Start();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            TroGiupTimer.Start();
        }





        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
           
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThongKeThucUong_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuongDanSuDung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://chanhdang.com/helper",
                UseShellExecute = true
            });
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
