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
    public partial class GUI_ChonXeTT : Form
    {
        BUS_Xe busXe;
        public static XE xett;
        public GUI_ChonXeTT()
        {
            InitializeComponent();
            busXe = new BUS_Xe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xett != null)
            {
                MessageBox.Show("Chọn thành công", "Chọn khách hàng");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị", "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells[1].Value.ToString();
            xett = busXe.chonXe(Convert.ToInt32(row.Cells[0].Value.ToString()));
        }

        private void ChonXeTT_Load(object sender, EventArgs e)
        {
            busXe.getXeChuaTT(dataGridView1);
        }
    }
}
