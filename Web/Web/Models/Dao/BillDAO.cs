using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models.Entity;

namespace Web.Models.Dao
{
    public class BillDAO
    {
        ShopModel db = new ShopModel();

        public void update(int id)
        {
            var bill = db.bills.Find(id);
                bill.status = "đã gói";
                db.SaveChanges();
        }
    }
}