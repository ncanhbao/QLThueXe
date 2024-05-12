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
    class BUS_Khach
    {
        DAL_Khach dalKhach;
        public BUS_Khach()
        {
            dalKhach = new DAL_Khach();
        }
        public void getKhach(DataGridView dgv)
        {
            dgv.DataSource = dalKhach.getKhach();
        }
        public bool themKhach(KHACH khach)
        {
            try
            {
                dalKhach.themKhach(khach);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool suaKhach(KHACH khach)
        {
            try
            {
                dalKhach.suaKhach(khach);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool xoaKhach(KHACH khach)
        {
            try
            {
                dalKhach.xoaKhach(khach);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public dynamic timKhach(string searchvalue1, string searchvalue2, string searchvalue3, string searchvalue4)
        {
            return dalKhach.timKhach(searchvalue1, searchvalue2, searchvalue3, searchvalue4);
        }
    }
}
