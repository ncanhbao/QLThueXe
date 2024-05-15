using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace EFDatabaseFirst
{
    public partial class GUI_Khach : Form
    {
        BUS_Khach busKhach;
        int count;
        public GUI_Khach()
        {
            InitializeComponent();
            busKhach = new BUS_Khach();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_Khach_Them formThem = new GUI_Khach_Them();
            formThem.ShowDialog();
        }
        private void GUI_Xe_Load(object sender, EventArgs e)
        {
            busKhach.getKhach(dgvKhach);
            count = dgvKhach.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string dateFormat = "dd/MM/yyyy";
            // Kiểm tra nếu có chọn table rồi
            if (dgvKhach.SelectedRows.Count > 0)
            {
                if (txthoten.Text != "" && txtdiachi.Text != "" && txtgioitinh.Text != "" && txtsodt.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvKhach.SelectedRows[0];

                    KHACH khach = new KHACH();
                    khach.MaKhach = Convert.ToInt16(row.Cells[0].Value.ToString());
                    khach.HoTen = txthoten.Text;
                    khach.DiaChi = txtdiachi.Text;
                    khach.GioiTinh = txtgioitinh.Text;
                    khach.SoDT = txtsodt.Text;
                    DateTime.TryParseExact(txtngaysinh.Text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh);
                    khach.NgaySinh = ngaySinh;
                    // Sửa
                    if (busKhach.suaKhach(khach))
                    {
                        MessageBox.Show("Sửa thành công");
                        busKhach.getKhach(dgvKhach); // refresh datagridview
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


        private void btnAll_Click(object sender, EventArgs e)
        {
            busKhach.getKhach(dgvKhach);
            count = dgvKhach.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvKhach.SelectedRows.Count > 0)
            {
                // Lấy MaXe của hàng được chọn
                DataGridViewRow row = dgvKhach.SelectedRows[0];
                KHACH khach = new KHACH();
                khach.MaKhach = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    if (busKhach.xoaKhach(khach))
                    {
                        MessageBox.Show("Xóa thành công");
                        busKhach.getKhach(dgvKhach); // refresh datagridview
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string hoten = txtSearch1.Text;
            string diachi = txtSearch2.Text;
            string gioitinh = txtSearch3.Text;
            string sdt = txtSearch4.Text;

            var ds = busKhach.timKhach(hoten, diachi, gioitinh, sdt);
            if (ds.Count > 0)
            {
                dgvKhach.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = dgvKhach.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void dgvXe_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvKhach.SelectedRows[0];
            txtmakhach.Text = row.Cells[0].Value.ToString();
            txthoten.Text = row.Cells[1].Value.ToString();
            txtdiachi.Text = row.Cells[2].Value.ToString();
            txtgioitinh.Text = row.Cells[3].Value.ToString();
            txtsodt.Text = row.Cells[4].Value.ToString();
            txtngaysinh.Text = Convert.ToDateTime(row.Cells[5].Value).ToString("dd/MM/yyyy");
        }
    }
}