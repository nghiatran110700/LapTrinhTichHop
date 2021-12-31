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
    //đang chỉnh đến phần edit
    public class AccountsController : Controller
    {
        private ShopModel db = new ShopModel();
        AccountService.Account_AdminClient ac = new AccountService.Account_AdminClient();
        // GET: Accounts
        public ActionResult Index()
        {
            List<Account> list = new List<Account>();
            var lst = ac.list_acc();
            foreach(var item in lst)
            {
                Account acc = new Account();
                acc.id = item.id;
                acc.username = item.username;
                acc.password = item.password;
                acc.status = item.status;
                list.Add(acc);
            }
            return View(list);
        }

        // GET: Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,fullname,username,password,status")] Account account)
        {
            if (ModelState.IsValid)
            {
                AccountService.Account acc = new AccountService.Account();
                acc.id = account.id;
                acc.username = account.username;
                acc.password = account.password;
                acc.status = account.status;
                acc.fullname = account.fullname;
                ac.add_acc(acc);
                //db.Accounts.Add(account);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(account);
        }

        // GET: Accounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fullname,username,password,status")] Account account)
        {
            if (ModelState.IsValid)
            {
                AccountService.Account acc = new AccountService.Account();
                acc.id = account.id;
                acc.username = account.username;
                acc.password = account.password;
                acc.status = account.status;
                acc.fullname = account.fullname;
                ac.edit_cate(acc);
                //db.Entry(account).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        // GET: Accounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Account account = db.Accounts.Find(id);
            AccountService.Account acc = new AccountService.Account();
            acc.id = account.id;
            acc.username = account.username;
            acc.password = account.password;
            acc.status = account.status;
            acc.fullname = account.fullname;
            ac.delete_acc(acc.id);
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
