using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.Models.Entity;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        private ShopModel db = new ShopModel();
        CategoryService.Category_AdminClient ca = new CategoryService.Category_AdminClient();
        // GET: Category
        public ActionResult Index()
        {
            List<category> list = new List<category>();
            var lst = ca.list_cate();
            foreach(var item in lst)
            {
                category cate = new category();
                cate.idCategory = item.idCategory;
                cate.nameCategory = item.nameCategory;
                list.Add(cate);
            }
            return View(list);
        }


        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCategory,nameCategory")] category category)
        {
            if (ModelState.IsValid)
            {
                CategoryService.category cate = new CategoryService.category();
                cate.idCategory = category.idCategory;
                cate.nameCategory = category.nameCategory;
                ca.add_cate(cate);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category category = db.categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCategory,nameCategory")] category category)
        {
            if (ModelState.IsValid)
            {
                CategoryService.category cate = new CategoryService.category();
                cate.idCategory = category.idCategory;
                cate.nameCategory = category.nameCategory;
                ca.edit_cate(cate);
                //db.Entry(category).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category category = db.categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            category category = db.categories.Find(id);
            CategoryService.category cate = new CategoryService.category();
            cate.idCategory = category.idCategory;
            cate.nameCategory = category.nameCategory;
            ca.delete_cate(cate.idCategory);
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
