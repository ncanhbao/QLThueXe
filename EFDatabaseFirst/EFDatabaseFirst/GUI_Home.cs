using EFDatabaseFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst
{
    public partial class GUI_Home : Form
    {
        bool sidebarExpand;
        bool panelQLCollapse;
        public GUI_Home()
        {
            InitializeComponent();
            txtusername.Text = GUI_DangNhap.user.HoTen;
            lbchucdanh.Text = GUI_DangNhap.user.ChucDanh;
            if (lbchucdanh.Text != "Quản lý")
            {
                btntrangchu.Enabled = false;

                btnQLxe.Enabled = false;

                btnQLkhach.Enabled = false;

                btnnhanvien.Enabled = false;

                btnhoadon.Enabled = false;

                if (lbchucdanh.Text == "NV cửa hàng")
                {
                    btnbaocao.Enabled = false;
                    btnthuchi.Enabled = false;
                }
            }

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                panelmain.Width += 10;
                panelmain.Left -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width && panelmain.Width == panelmain.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                panelmain.Width -= 10;
                panelmain.Left += 10;

                if (sidebar.Width == sidebar.MaximumSize.Width && panelmain.Width == panelmain.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }



        private void btnQLxe_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_Xe Form_Xe = new GUI_Xe(); // Khởi tạo một instance mới của form GUI_Xe
            Form_Xe.TopLevel = false;
            Form_Xe.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_Xe);
            Form_Xe.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_DangNhap f = new GUI_DangNhap();
            f.Show();
        }

        private void btnQLkhach_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_Khach Form_Khach = new GUI_Khach();
            Form_Khach.TopLevel = false;
            Form_Khach.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_Khach);
            Form_Khach.Show();
        }

        private void panelQLTimer_Tick(object sender, EventArgs e)
        {
            if (panelQLCollapse)
            {
                panelQL.Height += 10;
                if (panelQL.Height == panelQL.MaximumSize.Height)
                {
                    panelQLCollapse = false;
                    panelQLTimer.Stop();
                }
            }
            else
            {
                panelQL.Height -= 10;

                if (panelQL.Height == panelQL.MinimumSize.Height)
                {
                    panelQLCollapse = true;
                    panelQLTimer.Stop();
                }
            }
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            panelQLTimer.Start();
        }


        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_NhanVien Form_NhanVien = new GUI_NhanVien();
            Form_NhanVien.TopLevel = false;
            Form_NhanVien.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_NhanVien);
            Form_NhanVien.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
        }

        private void btnyeucau_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_YeuCau Form_YeuCau = new GUI_YeuCau();
            Form_YeuCau.TopLevel = false;
            Form_YeuCau.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_YeuCau);
            Form_YeuCau.Show();
        }

        private void btnthuchi_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_PhieuThuChi Form_Phieu = new GUI_PhieuThuChi();
            Form_Phieu.TopLevel = false;
            Form_Phieu.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_Phieu);
            Form_Phieu.Show();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_HoaDon Form_HD = new GUI_HoaDon();
            Form_HD.TopLevel = false;
            Form_HD.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_HD);
            Form_HD.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_ThongTinUser Form_User = new GUI_ThongTinUser();
            Form_User.TopLevel = false;
            Form_User.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_User);
            Form_User.Show();
        }

        private void btnbaoduong_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_BaoDuongXe Form_BaoDuong = new GUI_BaoDuongXe();
            Form_BaoDuong.TopLevel = false;
            Form_BaoDuong.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_BaoDuong);
            Form_BaoDuong.Show();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count > 0)
            {
                // Lấy form hiện tại ra khỏi panelMain và đóng nó
                Form currentForm = panelmain.Controls[0] as Form;
                currentForm.Close();
            }
            GUI_BaoCao Form_BaoCao = new GUI_BaoCao();
            Form_BaoCao.TopLevel = false;
            Form_BaoCao.Dock = DockStyle.Fill;
            panelmain.Controls.Add(Form_BaoCao);
            Form_BaoCao.Show();
        }
    }
}
