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
    public partial class GUI_Phieu_Them : Form
    {
        BUS_PhieuThuChi busPhieu;
        public GUI_Phieu_Them()
        {
            InitializeComponent();
            busPhieu = new BUS_PhieuThuChi();
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemKH_Click(object sender, EventArgs e)
        {
            GUI_ChonKhach formchonkhach = new GUI_ChonKhach();
            formchonkhach.ShowDialog();

            if (GUI_ChonKhach.khachthue != null)
            {
                txthoten.Text = GUI_ChonKhach.khachthue.HoTen;
                txtsdt.Text = GUI_ChonKhach.khachthue.SoDT;
                txtngaysinh.Text = Convert.ToDateTime(GUI_ChonKhach.khachthue.NgaySinh).ToString("dd/MM/yyyy");
                txtdiachi.Text = GUI_ChonKhach.khachthue.DiaChi;
                txtgioitinh.Text = GUI_ChonKhach.khachthue.GioiTinh;
            }
        }

        private void btnthemxe_Click(object sender, EventArgs e)
        {
            GUI_ChonXeTT formchonxe = new GUI_ChonXeTT();
            formchonxe.ShowDialog();

            if (GUI_ChonXeTT.xett != null)
            {
                txthangxe.Text = GUI_ChonXeTT.xett.HangXe;
                txtbienso.Text = GUI_ChonXeTT.xett.BienSo;
                txttinhtrang.Text = GUI_ChonXeTT.xett.TinhTrang;
                txtgia.Text = Convert.ToString(GUI_ChonXeTT.xett.Gia);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GUI_ChonXeTT.xett != null & GUI_ChonKhach.khachthue != null & cbloaiphieu.Text != "" & cbphuongthucTT.Text != "" & txtsotien.Text != "" & txtnoidung.Text != "")
            {
                PHIEUTHUCHI phieu = new PHIEUTHUCHI();
                phieu.LoaiPhieu = cbloaiphieu.Text;
                phieu.SoTien = Convert.ToInt32(txtsotien.Text);
                phieu.NVXuLy = GUI_DangNhap.user.HoTen;
                phieu.NgayTT = DateTime.Now;
                phieu.PhuongThucTT = cbphuongthucTT.Text;
                phieu.NoiDung = txtnoidung.Text;
                phieu.MaKhach = GUI_ChonKhach.khachthue.MaKhach;
                phieu.MaXe = GUI_ChonXeTT.xett.MaXe;
                if (busPhieu.themPhieu(phieu))
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
                if (GUI_ChonXeTT.xett == null)
                {
                    MessageBox.Show("Bạn chưa chọn xe", "Thiếu dữ liệu");
                }
                if (GUI_ChonKhach.khachthue == null)
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng", "Thiếu dữ liệu");
                }
                if (GUI_ChonXeTT.xett != null & GUI_ChonKhach.khachthue != null)
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin", "Chưa điền đủ thông tin");
                }
            } 
        }
    }
}
