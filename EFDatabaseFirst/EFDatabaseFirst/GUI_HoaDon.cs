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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace EFDatabaseFirst
{
    public partial class GUI_HoaDon : Form
    {
        BUS_HoaDon busHoaDon;
        int count;
        public GUI_HoaDon()
        {
            InitializeComponent();
            busHoaDon = new BUS_HoaDon();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            busHoaDon.getHoaDon(dgvHD);
            count = dgvHD.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void GUI_HoaDon_Load(object sender, EventArgs e)
        {
            busHoaDon.getHoaDon(dgvHD);
            count = dgvHD.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenkh = txtSearch1.Text;
            string hangxe = txtSearch2.Text;
            string trangthai = txtSearch3.Text;

            var ds = busHoaDon.timHoaDon(tenkh, hangxe, trangthai);
            if (ds.Count > 0)
            {
                dgvHD.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = dgvHD.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void dgvHD_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvHD.SelectedRows[0];
            txtmaHD.Text = row.Cells[0].Value.ToString();
            txttenKH.Text = busHoaDon.getKhach(busHoaDon.getYeuCau(Convert.ToInt32(row.Cells[1].Value)).MaKhach).HoTen;
            txthangxe.Text = busHoaDon.getXe(busHoaDon.getYeuCau(Convert.ToInt32(row.Cells[1].Value)).MaXe).HangXe;
            txttongtien.Text = row.Cells[2].Value.ToString();
            txttrangthai.Text = row.Cells[3].Value.ToString();
        }
    }
}
