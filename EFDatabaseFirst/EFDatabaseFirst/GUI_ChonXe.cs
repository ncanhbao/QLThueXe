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
    public partial class GUI_ChonXe : Form
    {
        BUS_Xe busXe;
        public static XE xethue;
        public GUI_ChonXe()
        {
            InitializeComponent();
            busXe = new BUS_Xe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xethue != null)
            {
                MessageBox.Show("Chọn thành công", "Chọn khách hàng");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị", "Lỗi");
            }
        }

        private void GUI_ChonXe_Load(object sender, EventArgs e)
        {
            busXe.getXeChuaThue(dataGridView1);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells[1].Value.ToString();
            xethue = busXe.chonXe(Convert.ToInt32(row.Cells[0].Value.ToString()));
        }
    }
}
