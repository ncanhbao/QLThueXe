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
    public partial class GUI_Xe_Them : Form
    {
        BUS_Xe busXe;
        public GUI_Xe_Them()
        {
            InitializeComponent();
            busXe = new BUS_Xe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txthangxe.Text != "" & txtbienso.Text != "" & cbtinhtrang.Text != "" & txtgia.Text != "")
            {
                XE xe = new XE();
                xe.HangXe = txthangxe.Text;
                xe.BienSo = txtbienso.Text;
                xe.TinhTrang = cbtinhtrang.Text;
                xe.Gia = Convert.ToInt32(txtgia.Text);
                if (busXe.themXe(xe))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
