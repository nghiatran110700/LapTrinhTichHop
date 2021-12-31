
using ShopService.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Login" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Login.svc or Login.svc.cs at the Solution Explorer and start debugging.
    public class Login : ILogin
    {
        ShopModel db = new ShopModel();

        public Account login(string name, string pass)
        {
            foreach(var item in db.Accounts)
            {
                if(name.Equals(item.username) && pass.Equals(item.password)){
                    return item;
                }
            }
            return null;
        }

        public void resig(Account acc)
        {
            db.Accounts.Add(acc);
            db.SaveChanges();
        }
    }
}
