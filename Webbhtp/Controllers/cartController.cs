using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Content
{
    public class cartController : Controller
    {
        BanHangThucPhamEntities myObj = new BanHangThucPhamEntities();
        // GET: cart
        public ActionResult Index()
        {
            if (Session["idUser"].Equals(" "))
            {
                return Redirect("~/Home/Login");
            } else
            {
                int iduser = (int)Session["idUser"];
                var cart = myObj.tb_Cart.Where(j => j.UserId == iduser).ToList();
                return View(cart);
            }
            
        }
        public ActionResult AddCart(int id)
        {
            int iduser = (int)Session["idUser"];
            List<tb_Cart> cart = new List<tb_Cart>();
            cart = cart.Where(j => j.UserId == iduser).ToList();
            if (cart.FirstOrDefault(m => m.ProductId == id) == null) // ko co sp nay trong gio hang
            {
                tb_Cart newItem = new tb_Cart()
                {
                    UserId = iduser,
                    ProductId = id,
                    Quantity = 1,

                };  // Tạo ra 1 CartItem mới
                myObj.tb_Cart.Add(newItem);
                myObj.SaveChanges();// Thêm CartItem vào giỏ 
            }
            else
            {
                // Nếu sản phẩm khách chọn đã có trong giỏ hàng thì không thêm vào giỏ nữa mà tăng số lượng lên.
                tb_Cart cardItem = cart.FirstOrDefault(m => m.ProductId == id);
                cardItem.Quantity++;
                myObj.SaveChanges();
            }
            return Redirect(url: Request.UrlReferrer.ToString());
        }
        public RedirectToRouteResult SuaSoLuong(int SanPhamID, int soluongmoi)
        {
            int iduser = (int)Session["idUser"];
            var cart = myObj.tb_Cart.Where(j => j.UserId == iduser).ToList();
            tb_Cart itemSua = cart.FirstOrDefault(m => m.ProductId == SanPhamID);
            if (itemSua != null)
            {
                itemSua.Quantity = soluongmoi;
                myObj.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult XoaKhoiGio(int? SanPhamID)
        {
            int iduser = (int)Session["idUser"];
            var cart = myObj.tb_Cart.Where(j => j.UserId == iduser).ToList();
            tb_Cart xoa = cart.FirstOrDefault(m => m.ProductId == SanPhamID);
            if (xoa != null)
            {
                myObj.tb_Cart.Remove(xoa);
                myObj.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}