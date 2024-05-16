using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.DAL
{
    class DAL_HoaDon
    {
        rentaldbEntities db;
        public DAL_HoaDon()
        {
            db = new rentaldbEntities();
        }
        public dynamic getHoaDon()
        {
            var ds = db.HOADONs.Select(s => new
            {
                s.MaHD,
                s.MaYC,
                s.TongTien,
                s.TrangThai,
                s.MaXe
            }).ToList();
            return ds;
        }
        public void themHoaDon(HOADON hd)
        {
            db.HOADONs.Add(hd);
            db.SaveChanges();
        }
        public dynamic timHoaDon(string searchvalue1, string searchvalue2, string searchvalue3)
        {

            var query = from hd in db.HOADONs
                        join yc in db.YEUCAUs on hd.MaYC equals yc.MaYC
                        join xe in db.XEs on yc.MaXe equals xe.MaXe
                        join kh in db.KHACHes on yc.MaKhach equals kh.MaKhach
                        select new
                        {
                            hd.MaHD,
                            hd.MaYC,
                            hd.TongTien,
                            hd.TrangThai,
                            hd.MaXe,
                            kh.HoTen,
                            xe.HangXe
                        };

            if (!string.IsNullOrEmpty(searchvalue1))
            {
                query = query.Where(a => a.HoTen.Contains(searchvalue1));
            }
            if (!string.IsNullOrEmpty(searchvalue2))
            {
                query = query.Where(a => a.HangXe.Contains(searchvalue2));

            }
            if (!string.IsNullOrEmpty(searchvalue3))
            {
                query = query.Where(a => a.TrangThai.Contains(searchvalue3));

            }

            // Thực thi truy vấn và trả về kết quả
            var ds = query.Select(s => new
            {
                s.MaHD,
                s.MaYC,
                s.TongTien,
                s.TrangThai,
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
        public XE getXe(int maxe)
        {
            XE a = new XE();
            var query = db.XEs.Where(x => x.MaXe == maxe);
            a = query.FirstOrDefault();
            return a;
        }
        public YEUCAU getYeuCau(int mayc)
        {
            YEUCAU a = new YEUCAU();
            var query = db.YEUCAUs.Where(x => x.MaYC == mayc);
            a = query.FirstOrDefault();
            return a;
        }
    }
}
