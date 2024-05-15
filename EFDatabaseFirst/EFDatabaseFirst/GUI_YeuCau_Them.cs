using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst
{
    public partial class GUI_YeuCau_Them : Form
    {
        BUS_YeuCau busYeuCau;
        public GUI_YeuCau_Them()
        {
            InitializeComponent();
            busYeuCau = new BUS_YeuCau();
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
            GUI_ChonXe formchonxe = new GUI_ChonXe();
            formchonxe.ShowDialog();

            if (GUI_ChonXe.xethue != null)
            {
                txthangxe.Text = GUI_ChonXe.xethue.HangXe;
                txtbienso.Text = GUI_ChonXe.xethue.BienSo;
                txttinhtrang.Text = GUI_ChonXe.xethue.TinhTrang;
                txtgia.Text = Convert.ToString(GUI_ChonXe.xethue.Gia);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (GUI_ChonXe.xethue != null & GUI_ChonKhach.khachthue != null & dtpngaytra.Value > dtpngaylay.Value)
            {
                YEUCAU yeucau = new YEUCAU();
                yeucau.MaKhach = GUI_ChonKhach.khachthue.MaKhach;
                yeucau.MaXe = GUI_ChonXe.xethue.MaXe;
                yeucau.NgayLay = dtpngaylay.Value;
                yeucau.NgayTra = dtpngaytra.Value;
                yeucau.NgayTaoYC = DateTime.Now;
                yeucau.TrangThai = "Chờ xử lý";
                if (busYeuCau.themYeuCau(yeucau))
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
                if (GUI_ChonKhach.khachthue == null)
                {
                    MessageBox.Show("Bạn chưa thêm khách hàng", "Lỗi");
                }
                if (GUI_ChonXe.xethue == null)
                {
                    MessageBox.Show("Bạn chưa chọn xe", "Lỗi");
                }
                if (dtpngaytra.Value <= dtpngaylay.Value)
                {
                    MessageBox.Show("Thời gian thuê không hợp lệ", "Lỗi");
                }    
            }
           
        }
    }
}
