using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.DAL
{
    class DAL_NhanVien
    {
        rentaldbEntities db;
        public DAL_NhanVien()
        {
            db = new rentaldbEntities();
        }
        public dynamic getNhanVien()
        {
            var ds = db.NHANVIENs.Select(s => new
            {
                s.MaNV,
                s.HoTen,
                s.GioiTinh,
                s.SoDT,
                s.NgaySinh,
                s.ChucDanh,
                s.TaiKhoan,
                s.MatKhau
            }).ToList();
            return ds;
        }
        public void themNhanVien(NHANVIEN nv)
        {
            db.NHANVIENs.Add(nv);
            db.SaveChanges();
        }
        public void suaNhanVien(NHANVIEN nv)
        {
            NHANVIEN k = db.NHANVIENs.Find(nv.MaNV);
            k.HoTen = nv.HoTen;
            k.GioiTinh = nv.GioiTinh;
            k.SoDT = nv.SoDT;
            k.NgaySinh = nv.NgaySinh;
            k.ChucDanh = nv.ChucDanh;
            k.TaiKhoan = nv.TaiKhoan;
            k.MatKhau = nv.MatKhau;
            db.SaveChanges();
        }
        public void xoaNhanVien(NHANVIEN nv)
        {
            NHANVIEN k = db.NHANVIENs.Find(nv.MaNV);
            db.NHANVIENs.Remove(k);
            db.SaveChanges();
        }
        public dynamic timNhanVien(string searchvalue1, string searchvalue2, string searchvalue4)
        {
            try
            {
                var query = db.NHANVIENs.AsQueryable();

                if (!string.IsNullOrEmpty(searchvalue1))
                {
                    query = query.Where(nv => nv.HoTen.Contains(searchvalue1));
                }
                if (!string.IsNullOrEmpty(searchvalue2))
                {
                    query = query.Where(nv => nv.SoDT.Contains(searchvalue2));

                }
                if (!string.IsNullOrEmpty(searchvalue4))
                {
                    query = query.Where(nv => nv.ChucDanh.Contains(searchvalue4));
                }
                // Thực thi truy vấn và trả về kết quả
                var ds = query.Select(s => new
                {
                    s.MaNV,
                    s.HoTen,
                    s.GioiTinh,
                    s.SoDT,
                    s.NgaySinh,
                    s.ChucDanh,
                    s.TaiKhoan,
                    s.MatKhau
                }).ToList();

                return ds;
            }
            catch { }
            return null;
        }
        public dynamic kiemTraDangNhap(string taikhoan, string matkhau)
        {
            var query = db.NHANVIENs.AsQueryable();
            query = query.Where(nv => nv.TaiKhoan == taikhoan && nv.MatKhau ==matkhau);
            var user = query.Select(s => new
            {
                s.MaNV,
                s.HoTen,
                s.GioiTinh,
                s.SoDT,
                s.NgaySinh,
                s.ChucDanh,
                s.TaiKhoan,
                s.MatKhau
            }).ToList();
            return user;
        }
    }
}
