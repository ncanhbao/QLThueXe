using EFDatabaseFirst.DAL;
using System;
using System.Collections.Generic;
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
    }
}
