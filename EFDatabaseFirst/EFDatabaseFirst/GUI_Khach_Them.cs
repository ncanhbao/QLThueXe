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
    public partial class GUI_Khach_Them : Form
    {
        BUS_Khach busKhach;
        public GUI_Khach_Them()
        {
            InitializeComponent();
            busKhach = new BUS_Khach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txthoten.Text != "" & txtdiachi.Text != "" & cbgioitinh.Text != "" & txtsdt.Text != "")
            {
                KHACH khach = new KHACH();
                khach.HoTen = txthoten.Text;
                khach.DiaChi = txtdiachi.Text;
                khach.GioiTinh = cbgioitinh.Text;
                khach.SoDT = txtsdt.Text;
                khach.NgaySinh = dtpngaysinh.Value;
                if (busKhach.themKhach(khach))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
