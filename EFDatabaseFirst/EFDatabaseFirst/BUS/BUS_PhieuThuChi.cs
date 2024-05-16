using EFDatabaseFirst.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst.BUS
{
    class BUS_PhieuThuChi
    {
        DAL_PhieuThuChi dalPhieu;
        public BUS_PhieuThuChi()
        {
            dalPhieu= new DAL_PhieuThuChi();
        }
        public void getPhieu(DataGridView dgv)
        {
            dgv.DataSource = dalPhieu.getPhieu();
        }
        public bool themPhieu(PHIEUTHUCHI phieu)
        {
            try
            {
                dalPhieu.themPhieu(phieu);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool xoaPhieu(PHIEUTHUCHI a)
        {
            try
            {
                dalPhieu.xoaPhieu(a);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public dynamic timPhieu(string searchvalue1, int searchvalue2, string searchvalue3, string searchvalue4)
        {
            return dalPhieu.timPhieu(searchvalue1, searchvalue2, searchvalue3, searchvalue4);
        }
        public KHACH getKhach(int makh)
        {
            return dalPhieu.getKhach(makh);
        }
    }
}
