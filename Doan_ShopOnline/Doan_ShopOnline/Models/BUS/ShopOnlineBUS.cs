using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopOnlineConnection;

namespace Doan_ShopOnline.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham Chitiet(String a)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0", a);
        }
    }
}