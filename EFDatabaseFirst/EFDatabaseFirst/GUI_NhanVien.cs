using EFDatabaseFirst.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst
{
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busNhanVien;
        int count;
        public GUI_NhanVien()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_NhanVien_Them formThem = new GUI_NhanVien_Them();
            formThem.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            busNhanVien.getNhanVien(dgvNV);
            count = dgvNV.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                // Lấy MaXe của hàng được chọn
                DataGridViewRow row = dgvNV.SelectedRows[0];
                NHANVIEN nv = new NHANVIEN();
                nv.MaNV = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    if (busNhanVien.xoaNhanVien(nv))
                    {
                        MessageBox.Show("Xóa thành công");
                        busNhanVien.getNhanVien(dgvNV); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string dateFormat = "dd/MM/yyyy";
            if (dgvNV.SelectedRows.Count > 0)
            {
                if (txthoten.Text != "" && txtgioitinh.Text != "" && txtsdt.Text != "" && txtngaysinh.Text != "" && txtchucdanh.Text != "" && txttaikhoan.Text != "" && txtmatkhau.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvNV.SelectedRows[0];

                    NHANVIEN nv = new NHANVIEN();
                    nv.MaNV = Convert.ToInt16(row.Cells[0].Value.ToString());
                    nv.HoTen = txthoten.Text;
                    nv.GioiTinh = txtgioitinh.Text;
                    nv.SoDT = txtsdt.Text;
                    DateTime.TryParseExact(txtngaysinh.Text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh);
                    nv.NgaySinh = ngaySinh;
                    nv.ChucDanh = txtchucdanh.Text;
                    nv.TaiKhoan = txttaikhoan.Text;
                    nv.MatKhau = txtmatkhau.Text;
                    // Sửa
                    if (busNhanVien.suaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        busNhanVien.getNhanVien(dgvNV); // refresh datagridview
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string hoten = txtSearch1.Text;
            string sdt = txtSearch2.Text;
            string chucdanh = txtSearch4.Text;

            var ds = busNhanVien.timNhanVien(hoten, sdt, chucdanh);
            if (ds.Count > 0)
            {
                dgvNV.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            count = dgvNV.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            busNhanVien.getNhanVien(dgvNV);
            count = dgvNV.Rows.Count;
            lbketqua.Text = count.ToString() + " kết quả";
        }

        private void dgvNV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvNV.SelectedRows[0];
            txtmanv.Text = row.Cells[0].Value.ToString();
            txthoten.Text = row.Cells[1].Value.ToString();
            txtgioitinh.Text = row.Cells[2].Value.ToString();
            txtsdt.Text = row.Cells[3].Value.ToString();
            txtngaysinh.Text = Convert.ToDateTime(row.Cells[4].Value).ToString("dd/MM/yyyy");
            txtchucdanh.Text = row.Cells[5].Value.ToString();
            txttaikhoan.Text = row.Cells[6].Value.ToString();
            txtmatkhau.Text = row.Cells[7].Value.ToString();
        }
    }
}
