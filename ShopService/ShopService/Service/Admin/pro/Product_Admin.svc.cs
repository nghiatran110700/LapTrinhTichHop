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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Product_Admin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Product_Admin.svc or Product_Admin.svc.cs at the Solution Explorer and start debugging.
    public class Product_Admin : IProduct_Admin
    {
        ShopModel db = new ShopModel();
        public void add_pro(Product pro)
        {
            db.Products.Add(pro);
            db.SaveChanges();
        }

        public void update_pro(Product pro)
        {
            Product product = findById(pro.idProduct);
            if(product != null)
            {
                product.nameProduct = pro.nameProduct;
                product.price = pro.price;
                product.amuont = pro.amuont;
                product.description = pro.description;
                product.photo = pro.photo;
                product.idCategory = pro.idCategory;
                db.SaveChanges();
            }
        }

        public void delete_pro(int id)
        {
            Product pro = findById(id);
            db.Products.Remove(pro);
            db.SaveChanges();
            
        }

        public List<ProductDTO> list_Pro()
        {
            var list = from p in db.Products
                   join c in db.categories on p.idCategory equals c.idCategory
                   select new ProductDTO()
                   {
                       idProduct = p.idProduct,
                       nameProduct = p.nameProduct,
                       price = p.price,
                       amuont = p.amuont,
                       photo = p.photo,
                       description = p.description,
                       idCategory = c.idCategory,
                       nameCategory = c.nameCategory
                   };
            return list.ToList();
        }

        public List<ProductDTO> search_pro(string name)
        {
            var lst = db.Database.SqlQuery<ProductDTO>("select" +
               " p.idProduct, " +
               " p.nameProduct, " +
               " p.price, " +
               " p.amuont, " +
               " p.photo, " +
               " p.description, " +
               " c.idCategory, " +
               " c.nameCategory " +
               " from Product as p left join category as c on p.idCategory = c.idCategory " +
                "where p.nameProduct LIKE '%" + name + "%'");
           
            return lst.ToList();
            
        }

        public Product findById(int id)
        {
            return db.Products.Find(id);
        }
        public List<ProductDTO> List_cate(int? id)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            var lst = db.Database.SqlQuery<ProductDTO>("select" +
               " p.idProduct, " +
               " p.nameProduct, " +
               " p.price, " +
               " p.amuont, " +
               " p.photo, " +
               " p.description, " +
               " c.idCategory, " +
               " c.nameCategory " +
               " from Product as p left join category as c on p.idCategory = c.idCategory " +
                "where c.idCategory ="+id);
            foreach (var item in lst)
            {
                ProductDTO pro = new ProductDTO();
                pro.idProduct = item.idProduct;
                pro.nameProduct = item.nameProduct;
                pro.price = item.price;
                pro.photo = item.photo;
                pro.idCategory = item.idCategory;
                pro.amuont = item.amuont;
                pro.description = item.description;
                pro.nameCategory = item.nameCategory;
                list.Add(pro);
            }
            return list;
        }
    }
}
