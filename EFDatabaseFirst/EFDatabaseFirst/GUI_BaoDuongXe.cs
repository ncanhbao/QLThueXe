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
    public partial class GUI_BaoDuongXe : Form
    {
        BUS_Xe busXe;
        BUS_HoaDon busHoaDon;
        public GUI_BaoDuongXe()
        {
            InitializeComponent();
            busXe = new BUS_Xe();
            busHoaDon = new BUS_HoaDon();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemxe_Click(object sender, EventArgs e)
        {
            GUI_ChonXe formchonxe = new GUI_ChonXe();
            formchonxe.ShowDialog();

            if (GUI_ChonXe.xethue != null)
            {
                txtmaxe.Text = GUI_ChonXe.xethue.MaXe.ToString();
                txthangxe.Text = GUI_ChonXe.xethue.HangXe;
                txtbienso.Text = GUI_ChonXe.xethue.BienSo;
                txttinhtrang.Text = GUI_ChonXe.xethue.TinhTrang;
                txtgia.Text = Convert.ToString(GUI_ChonXe.xethue.Gia);
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (GUI_ChonXe.xethue != null & txtchiphi.Text != null & txtnoidung != null)
            {
                XE xe = new XE();
                xe.MaXe = Convert.ToInt32(txtmaxe.Text);
                xe.HangXe = txthangxe.Text;
                xe.BienSo = txtbienso.Text;
                xe.TinhTrang = "Bảo dưỡng";
                xe.Gia = Convert.ToInt32(txtgia.Text);

                HOADON hd = new HOADON();
                hd.TongTien = Convert.ToInt32(txtchiphi.Text);
                hd.TrangThai = "Chưa thanh toán";
                hd.HangXe = txthangxe.Text;
                hd.NoiDung = txtnoidung.Text;
                busHoaDon.themHoaDon(hd);
                if (busXe.suaXe(xe))
                {
                    MessageBox.Show("Thao tác thành công");
                }
                else
                {
                    MessageBox.Show("Thao tác ko thành công");
                }
            }
            else 
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
        }
    }
}
