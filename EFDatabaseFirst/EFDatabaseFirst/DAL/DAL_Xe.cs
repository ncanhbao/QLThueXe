using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.DAL
{
    class DAL_Xe
    {
        rentaldbEntities db;
        public DAL_Xe()
        {
            db = new rentaldbEntities();
        }
        public dynamic getXe()
        {
            var ds = db.XEs.Select(s => new
            {
                s.MaXe,
                s.HangXe,
                s.BienSo,
                s.TinhTrang,
                s.Gia
            }).ToList();
            return ds;
        }
        public void themXe(XE xe)
        {
            db.XEs.Add(xe);
            db.SaveChanges();
        }
        public void suaXe(XE xe)
        {
            XE k = db.XEs.Find(xe.MaXe);
            k.HangXe = xe.HangXe;
            k.BienSo = xe.BienSo;
            k.TinhTrang = xe.TinhTrang;
            k.Gia = xe.Gia;
            db.SaveChanges();
        }
        public void xoaXe(XE xe)
        {
            XE k = db.XEs.Find(xe.MaXe);
            db.XEs.Remove(k);
            db.SaveChanges();
        }
        public dynamic timXe(string searchvalue1, string searchvalue3)
        {
            try
            {
                var query = db.XEs.AsQueryable();

                if (!string.IsNullOrEmpty(searchvalue1))
                {
                    query = query.Where(xe => xe.HangXe.Contains(searchvalue1));
                }
                if (!string.IsNullOrEmpty(searchvalue3))
                {
                    query = query.Where(xe => xe.TinhTrang.Contains(searchvalue3));
                }
                // Thực thi truy vấn và trả về kết quả
                var ds = query.Select(s => new
                {
                    s.MaXe,
                    s.HangXe,
                    s.BienSo,
                    s.TinhTrang,
                    s.Gia
                }).ToList();

                return ds;
            }
            catch { }
            return null;
        }
    }
}
