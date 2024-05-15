using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace EFDatabaseFirst
{
    public partial class GUI_YeuCau : Form
    {
        BUS_YeuCau busYeuCau;
        int count;
        public GUI_YeuCau()
        {
            InitializeComponent();
            busYeuCau = new BUS_YeuCau();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_YeuCau_Them formThem = new GUI_YeuCau_Them();
            formThem.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_YeuCau_Load(object sender, EventArgs e)
        {
            busYeuCau.getYeuCau(dgvYC);
            count = dgvYC.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void dgvYC_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvYC.SelectedRows[0];
            txtmaYC.Text = row.Cells[0].Value.ToString();
            txttenKH.Text = busYeuCau.getKhach(Convert.ToInt32(row.Cells[1].Value)).HoTen;
            txtsdt.Text = busYeuCau.getKhach(Convert.ToInt32(row.Cells[1].Value)).SoDT;
            txthangxe.Text = busYeuCau.getXe(Convert.ToInt32(row.Cells[2].Value)).HangXe;
            txtngaylay.Text = Convert.ToDateTime(row.Cells[3].Value).ToString("dd/MM/yyyy");
            txtngaytra.Text = Convert.ToDateTime(row.Cells[4].Value).ToString("dd/MM/yyyy");
            txttrangthai.Text = row.Cells[5].Value.ToString();
            txtngaytaoYC.Text = Convert.ToDateTime(row.Cells[6].Value).ToString("dd/MM/yyyy");
            if (row.Cells[7].Value != null & row.Cells[8].Value != null)
            {
                txtNVxuly.Text = row.Cells[7].Value.ToString();
                txtngayxuly.Text = Convert.ToDateTime(row.Cells[8].Value).ToString("dd/MM/yyyy");
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvYC.SelectedRows.Count > 0)
            {
                // Lấy MaXe của hàng được chọn
                DataGridViewRow row = dgvYC.SelectedRows[0];
                YEUCAU a = new YEUCAU();
                a.MaYC = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa yêu cầu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    if (busYeuCau.xoaYeuCau(a))
                    {
                        MessageBox.Show("Xóa thành công");
                        busYeuCau.getYeuCau(dgvYC); // refresh datagridview
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            busYeuCau.getYeuCau(dgvYC);
            count = dgvYC.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenkh = txtSearch1.Text;
            string hangxe = txtSearch2.Text;
            string trangthai = txtSearch3.Text;

            var ds = busYeuCau.timYeuCau(tenkh, hangxe, trangthai);
            if (ds.Count > 0)
            {
                dgvYC.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = dgvYC.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtmaYC.Text != "")
            {
                if (busYeuCau.capNhatYeuCau(Convert.ToInt32(txtmaYC.Text)))
                {
                    MessageBox.Show("Xử lý yêu cầu thành công");
                    busYeuCau.getYeuCau(dgvYC); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }   
            else
            {
                MessageBox.Show("Bạn chưa chọn yêu cầu để cập nhật");
            }
        }
    }
}
