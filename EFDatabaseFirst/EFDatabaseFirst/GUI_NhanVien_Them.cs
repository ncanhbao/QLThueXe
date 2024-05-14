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
    public partial class GUI_NhanVien_Them : Form
    {
        BUS_NhanVien busNhanVien;
        public GUI_NhanVien_Them()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txthoten.Text != "" & txtsdt.Text != "" & dtpngaysinh.Value != DateTime.MinValue & cbchucdanh.Text != "" & cbgioitinh.Text != "" & txttaikhoan.Text != "" & txtmatkhau.Text != "")
            {       
                NHANVIEN nv = new NHANVIEN();
                nv.HoTen = txthoten.Text;
                nv.SoDT = txtsdt.Text;
                nv.NgaySinh = dtpngaysinh.Value;
                nv.ChucDanh = cbchucdanh.Text;
                nv.GioiTinh = cbgioitinh.Text;
                nv.TaiKhoan = txttaikhoan.Text;
                nv.MatKhau = txtmatkhau.Text;
                    if (busNhanVien.themNhanVien(nv))
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
    }
}
