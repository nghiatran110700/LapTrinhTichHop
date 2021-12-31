using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopService.Model.DTO
{
    public class DetailBillDTO
    {
        public int idBill { get; set; }
        public int idProduct { get; set; }
        public string nameProduct { get; set; }
        public int price { get; set; }
        public int? amount { get; set; }
        public int total { get; set; }
    }
}