using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        BUS_HoaDon busHoaDon;
        BUS_Xe busXe;
        public GUI_Phieu_Them()
        {
            InitializeComponent();
            busPhieu = new BUS_PhieuThuChi();
            busHoaDon = new BUS_HoaDon();
            busXe = new BUS_Xe();
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GUI_ChonHoaDon.hoadon != null & cbloaiphieu.Text != "" & cbphuongthucTT.Text != "" & txtsotien.Text != "" & txtnoidung.Text != "")
            {
                if(Convert.ToInt32(txtsotien.Text) == Convert.ToInt32(txttongtien.Text))
                {
                    PHIEUTHUCHI phieu = new PHIEUTHUCHI();
                    YEUCAU yeucau = new YEUCAU();
                    HOADON hoadon = new HOADON(); 
                    phieu.LoaiPhieu = cbloaiphieu.Text;
                    phieu.SoTien = Convert.ToInt32(txtsotien.Text);
                    phieu.NVXuLy = GUI_DangNhap.user.HoTen;
                    phieu.NgayTT = DateTime.Now;
                    phieu.PhuongThucTT = cbphuongthucTT.Text;
                    phieu.NoiDung = txtnoidung.Text;
                    if (txttenKH.Text != "Cửa hàng cho thuê xe")
                    {
                        phieu.MaKhach = busHoaDon.getYeuCau(Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaYC)).MaKhach;
                        phieu.MaXe = busHoaDon.getYeuCau(Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaYC)).MaXe;
                        yeucau.MaYC = Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaYC);
                        yeucau.MaXe = busHoaDon.getYeuCau(Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaYC)).MaXe;
                        hoadon.MaHD = Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaHD);
                        if (busPhieu.themPhieu(phieu, yeucau, hoadon))
                        {
                            if (phieu.PhuongThucTT == "Chuyển khoản ngân hàng")
                            {
                                GUI_ChuyenKhoan ck = new GUI_ChuyenKhoan();
                                ck.ShowDialog();
                            }    
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm ko thành công");
                        }
                    }    
                    else
                    {
                        phieu.MaKhach = null;
                        phieu.MaXe = busXe.chonXeTheoHang(txthangxe.Text).MaXe;
                        hoadon.MaHD = Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaHD);
                        if (busPhieu.themPhieuThu(phieu, hoadon))
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm ko thành công");
                        }
                    }    
                }    
                else
                {
                    MessageBox.Show("Hãy nhập đúng số tiền cần thanh toán");
                }    
            }
            else
            {
                if (GUI_ChonHoaDon.hoadon == null)
                {
                    MessageBox.Show("Bạn chưa chọn hóa đơn", "Thiếu dữ liệu");
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin", "Chưa điền đủ thông tin");
                }
                
            } 
        }

        private void btnchonHD_Click(object sender, EventArgs e)
        {
            GUI_ChonHoaDon formchonhd = new GUI_ChonHoaDon();
            formchonhd.ShowDialog();

            if (GUI_ChonHoaDon.hoadon != null)
            {
                txtmaHD.Text = Convert.ToString(GUI_ChonHoaDon.hoadon.MaHD);
                if(GUI_ChonHoaDon.hoadon.NoiDung != null)
                {
                    txttenKH.Text = "Cửa hàng cho thuê xe";
                }
                else
                {
                    txttenKH.Text = busHoaDon.getKhach(busHoaDon.getYeuCau(Convert.ToInt32(GUI_ChonHoaDon.hoadon.MaYC)).MaKhach).HoTen;
                }
                txthangxe.Text = GUI_ChonHoaDon.hoadon.HangXe;
                txttongtien.Text = Convert.ToString(GUI_ChonHoaDon.hoadon.TongTien);
                txttrangthai.Text = Convert.ToString(GUI_ChonHoaDon.hoadon.TrangThai);
            }
        }
    }
}
