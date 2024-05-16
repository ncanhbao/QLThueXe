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
    class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon;
        public BUS_HoaDon()
        {
            dalHoaDon = new DAL_HoaDon();
        }
        public void getHoaDon(DataGridView dgv)
        {
            dgv.DataSource = dalHoaDon.getHoaDon();
        }
        public bool themHoaDon(HOADON hd)
        {
            try
            {
                dalHoaDon.themHoaDon(hd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public dynamic timHoaDon(string searchvalue1, string searchvalue2, string searchvalue3)
        {
            return dalHoaDon.timHoaDon(searchvalue1, searchvalue2, searchvalue3);
        }
        public KHACH getKhach(int makh)
        {
            return dalHoaDon.getKhach(makh);
        }
        public XE getXe(int maxe)
        {
            return dalHoaDon.getXe(maxe);
        }
        public YEUCAU getYeuCau(int mayc)
        {
            return dalHoaDon.getYeuCau(mayc);
        }
    }
}
