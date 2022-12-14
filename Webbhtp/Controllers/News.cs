using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbhtp.Controllers
{
    public class News
    {
        BanHangThucPhamEntities db = null;
        public News()
        {
            db = new BanHangThucPhamEntities();
        }

        public List<tb_News> ListAll()
        {
            return db.tb_News.Where(x => x.IsActive).ToList();
        }
    }
}