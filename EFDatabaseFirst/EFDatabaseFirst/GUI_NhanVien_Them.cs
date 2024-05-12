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
    public partial class GUI_NhanVien_Them : Form
    {
        public GUI_NhanVien_Them()
        {
            InitializeComponent();
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text != "" && txtsdt.Text != "" && txttaikhoan.Text != "" && txtmatkhau.Text != "" && dtpngaysinh.Value != DateTime.MinValue)
            {
                if (rbketoan.Checked || rbnvcuahang.Checked || rbquanly.Checked && rbnam.Checked || rbnu.Checked)
                {

                } 
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
