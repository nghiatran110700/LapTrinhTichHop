using ShopService.Model.DTO;
using ShopService.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService.Service.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Bill_Admin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Bill_Admin.svc or Bill_Admin.svc.cs at the Solution Explorer and start debugging.
    public class Bill_Admin : IBill_Admin
    {
        ShopModel db = new ShopModel();
        public void add_bill(bill bills)
        {
            db.bills.Add(bills);
            db.SaveChanges();
        }

        public void add_billDetail(billDetail detail)
        {
            if(db.bills.Find(detail.idBill) != null && db.Products.Find(detail.idProduct) != null)
            {
                db.billDetails.Add(detail);
                db.SaveChanges();
            }
            
            
        }

        public IEnumerable<DetailBillDTO> DetailBill(int id)
        {
            var list = db.Database.SqlQuery<DetailBillDTO>("Select " +
                                                        "d.idBill, " +
                                                        "p.idProduct," +
                                                        "p.nameProduct," +
                                                        " p.price, " +
                                                        "d.amount ," +
                                                        "d.amount*p.price as total " +
                                                        "from billDetail as d inner join Product p on d.idProduct = p.idProduct "
                                                      + " where d.idBill = " + id +
                                                        " group by d.idBill,p.idProduct, p.nameProduct, p.price, d.amount ");
            return list;
        }

        public IEnumerable<billDTO> list_bill()
        {

            var list = db.Database.SqlQuery<billDTO>("Select " +
                                                      "b.idBill,"+
                                                      "b.phone,"+
                                                      "b.address,"+
                                                      "b.status,"+
                                                      "sum(d.amount*p.price) as total "+
                                                      "from bill as b inner join billDetail as d on b.idBill = d.idBill "
                                                      + "inner join Product p on d.idProduct = p.idProduct "+
                                                      "group by b.idBill , b.phone, b.address, b.status");
            return list;
        }

        public int top()
        {
            int max = db.bills.Max(s => s.idBill);

            return max;

        }
        

        public void deleteBill(int id)
        {
            bill getbill = db.bills.Find(id);
            var detail = from list in db.billDetails where list.idBill.Equals(id) select list;
            foreach (var item in detail)
            {
                db.billDetails.Remove(item);
            }
            db.bills.Remove(getbill);
            db.SaveChanges();

        }
        public List<billDetail> test(int id)
        {
            List<billDetail> lst = new List<billDetail>();
            
            var detail = from list in db.billDetails where list.idBill.Equals(id) select list;
            foreach(var item in detail)
            {
                billDetail b = new billDetail();
                b.id = item.id;
                b.idBill = item.idBill;
                b.idProduct = item.idProduct;
                lst.Add(b);
            }
            return lst;
        }

    }
}
