using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbhtp.Controllers
{
    public class Producthome
    {
        BanHangThucPhamEntities db = null;
        public Producthome()
        {
            db = new BanHangThucPhamEntities();
        }

        public List<tb_ProductHome> ListAll()
        {
            return db.tb_ProductHome.Where(x=>x.IsActive).ToList();
        }
    }
}