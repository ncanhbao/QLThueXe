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
    class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien;
        public BUS_NhanVien()
        {
            dalNhanVien = new DAL_NhanVien();
        }
        public void getNhanVien(DataGridView dgv)
        {
            dgv.DataSource = dalNhanVien.getNhanVien();
        }
        public bool themNhanVien(NHANVIEN nv)
        {
            try
            {
                dalNhanVien.themNhanVien(nv);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool suaNhanVien(NHANVIEN nv)
        {
            try
            {
                dalNhanVien.suaNhanVien(nv);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool xoaNhanVien(NHANVIEN nv)
        {
            try
            {
                dalNhanVien.xoaNhanVien(nv);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public dynamic timNhanVien(string searchvalue1, string searchvalue2, string searchvalue4)
        {
            return dalNhanVien.timNhanVien(searchvalue1, searchvalue2, searchvalue4);
        }
    }
}
