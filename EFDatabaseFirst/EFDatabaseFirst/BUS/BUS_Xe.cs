﻿using EFDatabaseFirst.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst.BUS
{
    class BUS_Xe
    {
        DAL_Xe dalXe;
        public BUS_Xe()
        {
            dalXe = new DAL_Xe();
        }
        public void getXe(DataGridView dgv)
        {
            dgv.DataSource = dalXe.getXe();
        }
        public bool themXe(XE xe)
        {
            try
            {
                dalXe.themXe(xe);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaXe(XE xe)
        {
            try
            {
                dalXe.suaXe(xe);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool xoaXe(XE xe)
        {
            try
            {
                dalXe.xoaXe(xe);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public dynamic timXe(string searchvalue1, string searchvalue2, string searchvalue3)
        {
            return dalXe.timXe(searchvalue1, searchvalue2, searchvalue3);
        }
    }
}