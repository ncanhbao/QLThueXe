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
    public partial class GUI_ChonHoaDon : Form
    {
        BUS_HoaDon busHoaDon;
        public static HOADON hoadon;
        public GUI_ChonHoaDon()
        {
            InitializeComponent();
            busHoaDon = new BUS_HoaDon();
        }

        private void GUI_ChonHoaDon_Load(object sender, EventArgs e)
        {
            busHoaDon.getHoaDonChuaTT(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hoadon != null)
            {
                MessageBox.Show("Chọn thành công", "Chọn hóa đơn");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Lỗi");
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            hoadon = busHoaDon.chonHoaDon(Convert.ToInt32(row.Cells[0].Value.ToString()));
            textBox1.Text = hoadon.MaHD.ToString();
        }
    }
}
