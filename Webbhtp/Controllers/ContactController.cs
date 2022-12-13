using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp;

namespace Webbhtp.Content
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        BanHangThucPhamEntities myObj = new BanHangThucPhamEntities();
       

        public ActionResult Create(string name, string phone, string email, string message)
        {
            try
            {
                tb_Contact myItem = new tb_Contact();
                myItem.Name = name;
                myItem.Phone = phone;
                myItem.Email = email;
                myItem.Message = message;
                myItem.CreatedDate = DateTime.Now;
                myObj.tb_Contact.Add(myItem);
                myObj.SaveChanges();
                return Json(new { status = true });
            }
            catch
            {
                return Json(new { status = false });
            }
        }
    }
}