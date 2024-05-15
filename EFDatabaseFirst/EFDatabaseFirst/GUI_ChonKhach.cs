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
    public partial class GUI_ChonKhach : Form
    {
        BUS_Khach busKhach;
        public static KHACH khachthue;
        public GUI_ChonKhach()
        {
            InitializeComponent();
            busKhach = new BUS_Khach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_ChonKhach_Load(object sender, EventArgs e)
        {
            busKhach.getKhach(dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (khachthue != null)
            {
                MessageBox.Show("Chọn thành công", "Chọn khách hàng");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị", "Lỗi");
            } 
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells[1].Value.ToString();
            khachthue = busKhach.chonKhach(Convert.ToInt32(row.Cells[0].Value.ToString()));
        }

    }
}
