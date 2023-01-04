using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Content
{
    public class CheckoutController : Controller
    {
        BanHangThucPhamEntities myObj = new BanHangThucPhamEntities();
        // GET: Checkout
        public ActionResult Index()
        {   if (Session["idUser"].Equals(" "))
            {
                return RedirectToAction("Index", "Shop");
            } else
            {
                int userid = (int)Session["idUser"];
                List<tb_Cart> item = myObj.tb_Cart.Where(i => i.UserId == userid).ToList();
                if (item.Count > 0)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Shop");
                }
            }
            

        }
        [HttpPost]
        public ActionResult Checkout(FormCollection frm)
        {
            int userid = (int)Session["idUser"];
            tb_User user = myObj.tb_User.Find(userid);
            List<tb_Cart> item = myObj.tb_Cart.Where(i => i.UserId == userid).ToList();
            string username = user.FirstName + user.LastName;
            tb_Order order = new tb_Order()
            {
                UserId = userid,
                Code = frm["Code"],
                CustomerName = frm["CustomerName"],
                Phone = frm["Phone"],
                Email = frm["Email"],
                Address = frm["Address"],
                CreatedDate = DateTime.Now,
                CreatedBy = username,
            };
            myObj.tb_Order.Add(order);
            myObj.SaveChanges();

            foreach (var items in item)
            {
                tb_OrderDetail tb_OrderDetail = new tb_OrderDetail()
                {
                    OrderId = order.OrderId,
                    ProductId = items.ProductId,
                    Quantity = items.Quantity,
                };
                myObj.tb_OrderDetail.Add(tb_OrderDetail);
                myObj.tb_Cart.Remove(items);
                myObj.SaveChanges();
            }
            return View("Success");



        }


    }
}