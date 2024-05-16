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
                s.NgayTaoYC,
                s.NVXuLy,
                s.ThoiGianXuLy
            }).ToList();
            return ds;
        }
        public void themYeuCau(YEUCAU yeucau)
        {
            db.YEUCAUs.Add(yeucau);
            db.SaveChanges();
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
        public void xoaYeuCau(int mayc)
        {
            YEUCAU k = db.YEUCAUs.Find(mayc);
            db.YEUCAUs.Remove(k);
            db.SaveChanges();
        }
        public dynamic timYeuCau(string searchvalue1, string searchvalue2, string searchvalue3)
        {

            var query = from yc in db.YEUCAUs
                        join kh in db.KHACHes on yc.MaKhach equals kh.MaKhach
                        join xe in db.XEs on yc.MaXe equals xe.MaXe
                        select new
                        {
                            yc.MaYC,
                            yc.MaKhach,
                            yc.MaXe,
                            yc.NgayLay,
                            yc.NgayTra,
                            yc.TrangThai,
                            yc.NgayTaoYC,
                            yc.NVXuLy,
                            yc.ThoiGianXuLy,
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
                    s.MaYC,
                    s.MaKhach,
                    s.MaXe,
                    s.NgayLay,
                    s.NgayTra,
                    s.TrangThai,
                    s.NgayTaoYC,
                    s.NVXuLy,
                    s.ThoiGianXuLy
                }).ToList();

                return ds;
        }
        public void capNhatYeuCau(int mayeucau)
        {
            YEUCAU yc = new YEUCAU();
            XE xe = new XE();
            var query1 = db.YEUCAUs.Where(a => a.MaYC == mayeucau);
            yc = query1.FirstOrDefault();
            yc.TrangThai = "Chưa thanh toán";
            yc.NVXuLy = GUI_DangNhap.user.HoTen;
            yc.ThoiGianXuLy = DateTime.Now;
            var query2 = db.XEs.Where(a => a.MaXe == yc.MaXe);
            xe = query2.FirstOrDefault();
            xe.TinhTrang = "Đã thuê";
            db.SaveChanges();
        }
    }
}
