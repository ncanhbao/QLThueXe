using EFDatabaseFirst.BUS;
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
    public partial class GUI_DangNhap : Form
    {
        public static NHANVIEN user;
        BUS_NhanVien busNhanVien;
        public GUI_DangNhap()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text != "" & txtmatkhau.Text != "")
            {
                user = busNhanVien.kiemTraDangNhap(txttaikhoan.Text, txtmatkhau.Text);
                if (user != null)
                {
                    GUI_Home home = new GUI_Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi");
                    txttaikhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Lỗi");
                txttaikhoan.Focus();
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtmatkhau.PasswordChar = '*';
            }
            else
            {
                txtmatkhau.PasswordChar = '\0';
            }    
        }
    }
}
