using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.DAL
{
    class DAL_YeuCau
    {
        rentaldbEntities db;
        public DAL_YeuCau()
        {
            db = new rentaldbEntities();
        }
        public dynamic getYeuCau()
        {
            var ds = db.YEUCAUs.Select(s => new
            {
                s.MaYC,
                s.MaKhach,
                s.MaXe,
                s.NgayLay,
                s.NgayTra,
                s.TrangThai,
                s.NgayTaoYC
            }).ToList();
            return ds;
        }
        public void themYeuCau(YEUCAU yeucau)
        {
            db.YEUCAUs.Add(yeucau);
            db.SaveChanges();
        }
    }
}
