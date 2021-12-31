using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopService.Model.DTO
{
    public class billDTO
    {
        public int idBill { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public int total { get; set; }
    }
}