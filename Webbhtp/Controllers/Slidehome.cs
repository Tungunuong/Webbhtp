using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbhtp.Controllers
{
    public class Slidehome
    {
        BanHangThucPhamEntities db = null;
        public Slidehome()
        {
            db = new BanHangThucPhamEntities();
        }

        public List<tb_Slide> ListAll()
        {
            return db.tb_Slide.Where(x => x.IsActive).ToList();
        }
    }
}