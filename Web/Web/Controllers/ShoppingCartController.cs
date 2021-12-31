using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Web.Models.Dao;
using Web.Models.DTO;
using Web.Models.Entity;

namespace Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        ShopModel db = new ShopModel();
        Bill.Bill_AdminClient b = new Bill.Bill_AdminClient();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if(cart==null|| Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        } 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            var pro = db.Products.Single(s => s.idProduct == id);
            if (pro != null)
            {
                GetCart().add(pro);
            }
            return RedirectToAction("ShowCart", "ShoppingCart");
        }

        public ActionResult ShowCart()
        {
            if (Session["Cart"] == null)
            {
                return RedirectToAction("ShowCart", "ShoppingCart");
            }
                Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult Update_soluong(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            int id_pro = Int32.Parse(form["idProduct"]);
            int soluong = Int32.Parse(form["soluong"]);
            cart.updateSoLuong(id_pro, soluong);
            return RedirectToAction("ShowCart", "ShoppingCart");
        }
       public ActionResult RemoveCart(int id)
       {
            Cart cart = Session["Cart"] as Cart;
            cart.removeCart(id);
            return RedirectToAction("ShowCart", "ShoppingCart");
       }

        public ActionResult Success()
        {
            return View();
        }
       public ActionResult Checkout(FormCollection form)
        {
            try
            {
                Cart cart = Session["Cart"] as Cart;
                Bill.bill bill = new Bill.bill();
                //bill.idBill = 0;
                bill.phone = form["Phone"];
                bill.address = form["Address"];
                bill.status = "Đơn mới";
                b.add_bill(bill);
                int idLast = b.top();
                foreach(var item in cart.ITEMS)
                {
                        Bill.billDetail billDetail = new Bill.billDetail();
                        billDetail.idBill = idLast;
                        billDetail.idProduct = item.product.idProduct;
                        billDetail.amount = item.soluong;
                        b.add_billDetail(billDetail);
                }
            cart.clear();
            return RedirectToAction("Success", "ShoppingCart");

            }
            catch
            {
                return Content("Lỗi khi mua hàng mời bạn kiểm tra lại thông tin ");
            }
        }
    }
}