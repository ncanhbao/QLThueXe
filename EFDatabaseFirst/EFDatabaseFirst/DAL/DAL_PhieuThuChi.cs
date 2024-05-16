using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst.DAL
{
    class DAL_PhieuThuChi
    {
        rentaldbEntities db;
        public DAL_PhieuThuChi()
        {
            db = new rentaldbEntities();
        }
        public dynamic getPhieu()
        {
            var ds = db.PHIEUTHUCHIs.Select(s => new
            {
                s.MaPhieu,
                s.LoaiPhieu,
                s.SoTien,
                s.NVXuLy,
                s.NgayTT,
                s.PhuongThucTT,
                s.NoiDung,
                s.MaKhach,
                s.MaXe
            }).ToList();
            return ds;
        }
      
        public void themPhieu(PHIEUTHUCHI phieu, YEUCAU yeucau, HOADON hoadon)
        {
            db.PHIEUTHUCHIs.Add(phieu);
            YEUCAU yc = db.YEUCAUs.Find(yeucau.MaYC);
            yc.TrangThai = "Đã thanh toán";
            HOADON hd = db.HOADONs.Find(hoadon.MaHD);
            hd.TrangThai = "Đã thanh toán";
            XE xe = db.XEs.Find(yeucau.MaXe);
            xe.TinhTrang = "Chưa thuê";
            db.SaveChanges();
        }
        public void xoaPhieu(PHIEUTHUCHI phieu)
        {
            PHIEUTHUCHI k = db.PHIEUTHUCHIs.Find(phieu.MaPhieu);
            db.PHIEUTHUCHIs.Remove(k);
            db.SaveChanges();
        }
        public dynamic timPhieu(string searchvalue1, int searchvalue2, string searchvalue3, string searchvalue4)
        {

            var query = from s in db.PHIEUTHUCHIs
                        join kh in db.KHACHes on s.MaKhach equals kh.MaKhach
                        join xe in db.XEs on s.MaXe equals xe.MaXe
                        select new
                        {
                            s.MaPhieu,
                            s.LoaiPhieu,
                            s.SoTien,
                            s.NVXuLy,
                            s.NgayTT,
                            s.PhuongThucTT,
                            s.NoiDung,
                            s.MaKhach,
                            s.MaXe,
                            kh.HoTen,
                            xe.HangXe
                        };

            if (!string.IsNullOrEmpty(searchvalue1))
            {
                query = query.Where(a => a.HoTen.Contains(searchvalue1));
            }
            if (searchvalue2 > 0)
            {
                query = query.Where(a => a.SoTien.Equals(searchvalue2));

            }
            if (!string.IsNullOrEmpty(searchvalue3))
            {
                query = query.Where(a => a.LoaiPhieu.Contains(searchvalue3));

            }
            if (!string.IsNullOrEmpty(searchvalue4))
            {
                query = query.Where(a => a.HangXe.Contains(searchvalue3));

            }

            // Thực thi truy vấn và trả về kết quả
            var ds = query.Select(s => new
            {
                s.MaPhieu,
                s.LoaiPhieu,
                s.SoTien,
                s.NVXuLy,
                s.NgayTT,
                s.PhuongThucTT,
                s.NoiDung,
                s.MaKhach,
                s.MaXe
            }).ToList();

            return ds;
        }
        public KHACH getKhach(int makh)
        {
            KHACH a = new KHACH();
            var query = db.KHACHes.Where(x => x.MaKhach == makh);
            a = query.FirstOrDefault();
            return a;
        }
        public void themPhieuThu(PHIEUTHUCHI phieu, HOADON hoadon)
        {
            db.PHIEUTHUCHIs.Add(phieu);
            HOADON hd = db.HOADONs.Find(hoadon.MaHD);
            hd.TrangThai = "Đã thanh toán";
            XE xe = db.XEs.Find(phieu.MaXe);
            xe.TinhTrang = "Chưa thuê";
            db.SaveChanges();
        }
        }
}
