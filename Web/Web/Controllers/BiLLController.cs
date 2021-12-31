using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.Entity;
using Web.Models.Dao;
using Web.Models.DTO;

namespace Web.Controllers
{
    public class BiLLController : Controller
    {
        // GET: BiLL
        ShopModel db = new ShopModel();
        Bill.Bill_AdminClient b = new Bill.Bill_AdminClient();
        public ActionResult Index()
        {
            int tong = 0;
            var lst = b.list_bill();
            List<billDTO> list = new List<billDTO>();
            foreach(var item in lst)
            {
                billDTO bill = new billDTO();
                bill.idBill = item.idBill;
                bill.phone = item.phone;
                bill.status = item.status;
                bill.address = item.address;
                bill.total = item.total;
                tong += item.total;
                list.Add(bill);
            }
            Session["Doanh Thu"] = tong;
            return View(list);
        }
        public ActionResult Details(int id)
        {
            var lst = b.DetailBill(id);
            int tong = 0;
            List<DetailBillDTO> list = new List<DetailBillDTO>();
            foreach(var item in lst)
            {
                DetailBillDTO detail = new DetailBillDTO();
                detail.idBill = item.idBill;
                detail.idProduct = item.idProduct;
                detail.nameProduct = item.nameProduct;
                detail.price = item.price;
                detail.amount = item.amount;
                detail.total = item.total;
                list.Add(detail);
            }
            Session["Tổng Bill"] = tong;
            Session["Mã Đơn Hàng"] = id;
            
            return View(list);
        }
        public ActionResult agree(int id)
        {
            BillDAO b = new BillDAO();
            b.update(id);
            return RedirectToAction("Index", "BiLL");
        }
        public ActionResult delete(int id)
        {
            b.deleteBill(id);
            return RedirectToAction("Index", "Bill");
        }

    }
}