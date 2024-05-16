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
    public partial class GUI_PhieuThuChi : Form
    {
        BUS_PhieuThuChi busPhieu;
        int count;
        public GUI_PhieuThuChi()
        {
            InitializeComponent();
            busPhieu = new BUS_PhieuThuChi();
        }

        private void GUI_PhieuThuChi_Load(object sender, EventArgs e)
        {
            busPhieu.getPhieu(dgvPhieu);
            count = dgvPhieu.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_Phieu_Them formThem = new GUI_Phieu_Them(); 
            formThem.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            busPhieu.getPhieu(dgvPhieu);
            count = dgvPhieu.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int sotien = 0;
            string tenkh = txtSearch1.Text;
            if (txtSearch2.Text != "")
            {
                sotien = Convert.ToInt32(txtSearch2.Text);
            }    
            string loaiphieu = txtSearch3.Text;
            string hangxe = txtSearch4.Text;

            var ds = busPhieu.timPhieu(tenkh, sotien, loaiphieu, hangxe);
            if (ds.Count > 0)
            {
                dgvPhieu.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = dgvPhieu.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void dgvPhieu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvPhieu.SelectedRows[0];
            txtmaphieu.Text = row.Cells[0].Value.ToString();
            txtloaiphieu.Text = row.Cells[1].Value.ToString();
            txtsotien.Text = row.Cells[2].Value.ToString();
            txtNVxuly.Text = row.Cells[3].Value.ToString();
            txtngayxuly.Text = Convert.ToDateTime(row.Cells[4].Value).ToString("dd/MM/yyyy");
            txtphuongthucTT.Text = row.Cells[5].Value.ToString();
            txtnoidung.Text = row.Cells[6].Value.ToString();
            if (row.Cells[7].Value == null)
            {
                txttenKH.Text = "Cửa hàng cho thuê xe";
            }
            else
            {
                txttenKH.Text = busPhieu.getKhach(Convert.ToInt32(row.Cells[7].Value)).HoTen;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieu.SelectedRows.Count > 0)
            {
                // Lấy MaXe của hàng được chọn
                DataGridViewRow row = dgvPhieu.SelectedRows[0];
                PHIEUTHUCHI a = new PHIEUTHUCHI();
                a.MaPhieu = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu  này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    if (busPhieu.xoaPhieu(a))
                    {
                        MessageBox.Show("Xóa thành công");
                        busPhieu.getPhieu(dgvPhieu); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách muốn xóa");
            }
        }
    }
}
