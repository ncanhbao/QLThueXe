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

namespace GUI_QuanLy
{
    public partial class GUI_Home : Form
    {
        bool sidebarExpand;
        bool panelQLCollapse;
        public GUI_Home()
        {
            InitializeComponent();
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
     
        private void btndanhmuc_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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
            Application.Exit();
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

        private void label1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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
    }
}
