using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.Models.Entity;
using Web.Models.Dao;
using Web.Models.DTO;
using PagedList;

namespace Web.Controllers
{
    //đang sửa xong chỗ create rồi
    public class AdminController : Controller
    {
         ShopModel db = new ShopModel();
        ProductService.Product_AdminClient pa = new ProductService.Product_AdminClient();
        
        public ActionResult Index(string keyword, string minPrice, string maxPrice, int pageNum = 1, int pageSize = 5)
        {
            ProductDAO dao = new ProductDAO();
            if (!string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(minPrice) && !string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearch(keyword, minPrice, maxPrice, pageNum, pageSize));
            }

            else if (!string.IsNullOrEmpty(keyword) && string.IsNullOrEmpty(minPrice) && string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearchByName(keyword, pageNum, pageSize));
            }

            else if (string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(minPrice) && string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearchByMinPrice(minPrice, pageNum, pageSize));
            }

            else if (string.IsNullOrEmpty(keyword) && string.IsNullOrEmpty(minPrice) && !string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearchByMaxPrice(maxPrice, pageNum, pageSize));
            }

            else if (string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(minPrice) && !string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearchByPrice(minPrice, maxPrice, pageNum, pageSize));
            }

            else if (!string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(minPrice) && !string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearchByNameAndMaxPrice(keyword, maxPrice, pageNum, pageSize));
            }

            else if (!string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(minPrice) && string.IsNullOrEmpty(maxPrice))
            {
                return View(dao.lstSearchByNameAndMinPrice(keyword, minPrice, pageNum, pageSize));
            }

            List<ProductDTO> list = new List<ProductDTO>();
            var lst = pa.list_Pro();
            foreach(var item in lst)
            {
                ProductDTO pro = new ProductDTO();
                pro.idProduct = item.idProduct;
                pro.nameProduct = item.nameProduct;
                pro.price = item.price;
                pro.photo = item.photo;
                pro.idCategory = item.idCategory;
                pro.nameCategory = item.nameCategory;
                pro.amuont = item.amuont;
                pro.description = item.description;
                list.Add(pro);
            }
            return View(list.ToList().ToPagedList(pageNum, pageSize));
        }
       
        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.idCategory = new SelectList(db.categories, "idCategory", "nameCategory");
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProduct,nameProduct,price,amuont,photo,description,idCategory")] Product product, HttpPostedFileBase uploadhinh)
        {
            if (ModelState.IsValid)
            {
                if (uploadhinh != null && uploadhinh.ContentLength > 0)         
                {
                    var path = Path.Combine(Server.MapPath("~/Access/Imge/"), System.IO.Path.GetFileName(uploadhinh.FileName));
                    uploadhinh.SaveAs(path);
                    product.photo = uploadhinh.FileName;
                    db.SaveChanges();
                }
                ProductService.Product pro = new ProductService.Product();
                pro.idProduct = product.idProduct;
                pro.nameProduct = product.nameProduct;
                pro.price = product.price;
                pro.photo = product.photo;
                pro.idCategory = product.idCategory;
                pro.amuont = product.amuont;
                pro.description = product.description;
                pa.add_pro(pro);
                return RedirectToAction("Index");        // 
            }

            ViewBag.idCategory = new SelectList(db.categories, "idCategory", "nameCategory", product.idCategory);
            return RedirectToAction("Index");
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCategory = new SelectList(db.categories, "idCategory", "nameCategory", product.idCategory);
            return View(product);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idProduct,nameProduct,price,amuont,photo,description,idCategory")] Product product, HttpPostedFileBase uploadhinh)
        {
            if (ModelState.IsValid)
            {
                if (uploadhinh != null && uploadhinh.ContentLength > 0)   
                {
                    var path = Path.Combine(Server.MapPath("~/Access/Imge/"), System.IO.Path.GetFileName(uploadhinh.FileName));
                    uploadhinh.SaveAs(path);
                    product.photo = uploadhinh.FileName;
                    db.SaveChanges();
                }
                ProductService.Product pro = new ProductService.Product();
                pro.idProduct = product.idProduct;
                pro.nameProduct = product.nameProduct;
                pro.price = product.price;
                pro.photo = product.photo;
                pro.idCategory = product.idCategory;
                pro.amuont = product.amuont;
                pro.description = product.description;
                pa.update_pro(pro);
                return RedirectToAction("Index");  
            }
            ViewBag.idCategory = new SelectList(db.categories, "idCategory", "nameCategory", product.idCategory);
            return View(product);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            ProductService.Product pro = new ProductService.Product();
            pro.idProduct = product.idProduct;
            pro.nameProduct = product.nameProduct;
            pro.price = product.price;
            pro.photo = product.photo;
            pro.idCategory = product.idCategory;
            pro.amuont = product.amuont;
            pro.description = product.description;
            pa.delete_pro(pro.idProduct);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
