using ShopService.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService.Service.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Account_Admin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Account_Admin.svc or Account_Admin.svc.cs at the Solution Explorer and start debugging.
    public class Account_Admin : IAccount_Admin
    {
        ShopModel db = new ShopModel();
        public void add_acc(Account acc)
        {
            db.Accounts.Add(acc);
            db.SaveChanges();
        }

        public void delete_acc(int id)
        {
            Account acc = Find_acc(id);
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }

        public void edit_cate(Account acc)
        {
            Account account = Find_acc(acc.id);
            if (account != null)
            {
                account.username = acc.username;
                account.password = acc.password;
                account.fullname = acc.fullname;
                account.status = acc.status;
                db.SaveChanges();
            }
        }

        public Account Find_acc(int? id)
        {
            return db.Accounts.Find(id);
        }

        public List<Account> list_acc()
        {
            List<Account> lst = new List<Account>();
            var list = from account in db.Accounts select account;
            foreach(var acc in list)
            {
                Account account = new Account();
                account.id = acc.id;
                account.username = acc.username;
                account.password = acc.password;
                account.fullname = acc.fullname;
                account.status = acc.status;
                lst.Add(account);
            }
            return lst;
        }
    }
}
