using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbhtp.Controllers
{
    public class Blog
    {
        BanHangThucPhamEntities db = null;
        public Blog()
        {
            db = new BanHangThucPhamEntities();
        }

        public List<tb_Blog> ListAll()
        {
            return db.tb_Blog.Where(x => x.IsActive).ToList();
        }
    }
}