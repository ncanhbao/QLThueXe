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
    class BUS_YeuCau
    {
        DAL_YeuCau dalYeuCau;
        public BUS_YeuCau()
        {
            dalYeuCau = new DAL_YeuCau();
        }
        public void getYeuCau(DataGridView dgv)
        {
            dgv.DataSource = dalYeuCau.getYeuCau();
        }
        public bool themYeuCau(YEUCAU yeucau)
        {
            try
            {
                dalYeuCau.themYeuCau(yeucau);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public KHACH getKhach(int makh)
        {
            return dalYeuCau.getKhach(makh);
        }
        public XE getXe(int maxe)
        {
            return dalYeuCau.getXe(maxe);
        }
        public bool xoaYeuCau(YEUCAU a)
        {
            try
            {
                dalYeuCau.xoaYeuCau(a);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public dynamic timYeuCau(string searchvalue1, string searchvalue2, string searchvalue3)
        {
            return dalYeuCau.timYeuCau(searchvalue1, searchvalue2, searchvalue3);
        }
        public bool capNhatYeuCau(int mayeucau)
        {
            try
            {
                dalYeuCau.capNhatYeuCau(mayeucau);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
