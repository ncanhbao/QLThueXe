using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.DAL
{
    class DAL_Khach
    {
        rentaldbEntities db;
        public DAL_Khach()
        {
            db = new rentaldbEntities();
        }
        public dynamic getKhach()
        {
            var ds = db.KHACHes.Select(s => new
            {
                s.MaKhach,
                s.HoTen,
                s.DiaChi,
                s.GioiTinh,
                s.SoDT
            }).ToList();
            return ds;
        }
        public void themKhach(KHACH khach)
        {
            db.KHACHes.Add(khach);
            db.SaveChanges();
        }
        public void suaKhach(KHACH khach)
        {
            KHACH k = db.KHACHes.Find(khach.MaKhach);
            k.HoTen = khach.HoTen;
            k.DiaChi = khach.DiaChi;
            k.GioiTinh = khach.GioiTinh;
            k.SoDT = khach.SoDT;
            db.SaveChanges();
        }
        public void xoaKhach(KHACH khach)
        {
            KHACH k = db.KHACHes.Find(khach.MaKhach);
            db.KHACHes.Remove(k);
            db.SaveChanges();
        }
        public dynamic timKhach(string searchvalue1, string searchvalue2, string searchvalue3, string searchvalue4)
        {
            try
            {
                var query = db.KHACHes.AsQueryable();

                if (!string.IsNullOrEmpty(searchvalue1))
                {
                    query = query.Where(kh => kh.HoTen.Contains(searchvalue1));
                }
                if (!string.IsNullOrEmpty(searchvalue2))
                {
                    query = query.Where(kh => kh.DiaChi.Contains(searchvalue2));

                }
                if (!string.IsNullOrEmpty(searchvalue3))
                {
                    query = query.Where(kh => kh.GioiTinh.Contains(searchvalue3));

                }
                if (!string.IsNullOrEmpty(searchvalue4))
                {
                    query = query.Where(kh => kh.SoDT.Contains(searchvalue4));

                }
                // Thực thi truy vấn và trả về kết quả
                var ds = query.Select(s => new
                {
                    s.MaKhach,
                    s.HoTen,
                    s.DiaChi,
                    s.GioiTinh,
                    s.SoDT
                }).ToList();

                return ds;
            }
            catch { }
            return null;
        }
    }
}
