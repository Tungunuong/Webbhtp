using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbhtp.Controllers
{
    public class Productshop
    {
        BanHangThucPhamEntities db = null;
        public Productshop()
        {
            db = new BanHangThucPhamEntities();
        }

        public List<tb_Product> ListAll()
        {
            return db.tb_Product.Where(x => x.IsActive).ToList();
        }
    }
}