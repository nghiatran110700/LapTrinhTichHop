using ShopService.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService.Service.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Category_Admin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Category_Admin.svc or Category_Admin.svc.cs at the Solution Explorer and start debugging.
    public class Category_Admin : ICategory_Admin
    {
        ShopModel db = new ShopModel();
        public void add_cate(category cate)
        {
            db.categories.Add(cate);
            db.SaveChanges();
        }

        public void delete_cate(int id)
        {
            category cate = Find_cate(id);
            db.categories.Remove(cate);
            db.SaveChanges();
        }

        public void edit_cate(category cate)
        {
            category Category = Find_cate(cate.idCategory);
            if (Category != null)
            {
                Category.nameCategory = cate.nameCategory;
                db.SaveChanges();
            }
        }

        public category Find_cate(int id)
        {
            return db.categories.Find(id);
        }

        public List<category> list_cate()
        {
            List<category> lst = new List<category>();
            var list = (from c in db.categories select c).ToList();
            foreach(var item in list)
            {
                category cate = new category();
                cate.idCategory = item.idCategory;
                cate.nameCategory = item.nameCategory;
                lst.Add(cate);
            }
            return lst;
        }
    }
}
