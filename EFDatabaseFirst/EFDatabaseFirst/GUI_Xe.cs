using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace EFDatabaseFirst
{
    public partial class GUI_Xe : Form
    {
        BUS_Xe busXe;
        int count;
        public GUI_Xe()

        {
            InitializeComponent();
            busXe = new BUS_Xe();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_Xe_Them formThem = new GUI_Xe_Them();
            formThem.ShowDialog();
        }
        private void GUI_Xe_Load(object sender, EventArgs e)
        {
            busXe.getXe(dgvXe);
            count = dgvXe.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvXe.SelectedRows.Count > 0)
            {
                if (txthangxe.Text != "" & txtbienso.Text != "" & txttinhtrang.Text != "" & txtgia.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvXe.SelectedRows[0];
                    XE xe = new XE();
                    xe.MaXe = Convert.ToInt16(row.Cells[0].Value.ToString());
                    xe.HangXe = txthangxe.Text;
                    xe.BienSo = txtbienso.Text;
                    xe.TinhTrang = txttinhtrang.Text;
                    xe.Gia = Convert.ToInt32(txtgia.Text);
                    // Sửa
                    if (busXe.suaXe(xe))
                    {
                        MessageBox.Show("Sửa thành công");
                        busXe.getXe(dgvXe);// refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvXe.SelectedRows.Count > 0)
            {
                // Lấy MaXe của hàng được chọn
                DataGridViewRow row = dgvXe.SelectedRows[0];
                XE xe = new XE();
                xe.MaXe = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    if (busXe.xoaXe(xe))
                    {
                        MessageBox.Show("Xóa thành công");
                        busXe.getXe(dgvXe); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn xe muốn xóa");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô tìm kiếm
            string hangxe = txtSearch1.Text;
            string tinhtrang = txtSearch3.Text;

            var ds = busXe.timXe(hangxe, tinhtrang);
            if (ds != null)
            {
                dgvXe.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = dgvXe.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            busXe.getXe(dgvXe);
            count = dgvXe.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void dgvXe_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvXe.SelectedRows[0];
            txtmaxe.Text = row.Cells[0].Value.ToString();
            txthangxe.Text = row.Cells[1].Value.ToString();
            txtbienso.Text = row.Cells[2].Value.ToString();
            txttinhtrang.Text = row.Cells[3].Value.ToString();
            txtgia.Text = row.Cells[4].Value.ToString();
        }
    }
}