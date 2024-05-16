using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst
{
    public partial class GUI_ThongTinUser : Form
    {
        BUS_NhanVien busNhanVien;
        public GUI_ThongTinUser()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void GUI_ThongTinUser_Load(object sender, EventArgs e)
        {
            NHANVIEN a = new NHANVIEN();
            a = GUI_DangNhap.user;
            txtmaNV.Text = a.MaNV.ToString();
            txthoten.Text = a.HoTen.ToString();
            txtgioitinh.Text = a.GioiTinh.ToString();
            txtsdt.Text = a.SoDT.ToString();
            txtngaysinh.Text = Convert.ToDateTime(a.NgaySinh).ToString("dd/MM/yyyy");
            txtchucdanh.Text = a.ChucDanh.ToString();
            txtTK.Text = a.TaiKhoan.ToString();
            txtMK.Text = a.MatKhau.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateFormat = "dd/MM/yyyy";
            NHANVIEN nv = new NHANVIEN();
            nv.MaNV = Convert.ToInt32(txtmaNV.Text);
            nv.HoTen = txthoten.Text;
            nv.GioiTinh = txtgioitinh.Text;
            nv.SoDT = txtsdt.Text;
            DateTime.TryParseExact(txtngaysinh.Text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh);
            nv.NgaySinh = ngaySinh;
            nv.ChucDanh = txtchucdanh.Text;
            nv.TaiKhoan = txtTK.Text;
            nv.MatKhau = txtMK.Text;
            // Sửa
            if (busNhanVien.suaNhanVien(nv))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa ko thành công");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
