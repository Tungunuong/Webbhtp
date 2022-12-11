using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbhtp.Controllers
{
    public class Blog_single
    {
        BanHangThucPhamEntities db = null;
        public Blog_single()
        {
            db = new BanHangThucPhamEntities();
        }

        public List<tb_Blog> ListAll()
        {
            return db.tb_Blog.Where(x => x.IsActive).ToList();
        }
    }
}