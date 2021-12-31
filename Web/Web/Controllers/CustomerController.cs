using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.Entity;
using Web.Models.Dao;
using System.Net;
using Web.Models.DTO;
using PagedList;

namespace Web.Controllers
{
    public class CustomerController : Controller
    {
        ShopModel db = new ShopModel();
        ProductService.Product_AdminClient pa = new ProductService.Product_AdminClient();
        // GET: Customer
        public ActionResult Index(string keyword , int pageNum = 1,int pageSize = 5)
        {
            List<ProductDTO> list = new List<ProductDTO>();

            if (keyword != null)
            {
                ProductDAO dao = new ProductDAO();
                return View(dao.SearchByNameService(keyword,pageNum,pageSize));
            }
            
            var lst = pa.list_Pro();
            foreach (var item in lst)
            {
                ProductDTO pro = new ProductDTO();
                pro.idProduct = item.idProduct;
                pro.nameProduct = item.nameProduct;
                pro.price = item.price;
                pro.photo = item.photo;
                pro.idCategory = item.idCategory;
                pro.nameCategory = item.nameCategory;
                pro.amuont = item.amuont;
                pro.description = item.description;
                list.Add(pro);
            }
            return View(list.ToList().ToPagedList(pageNum,pageSize));
            
        }
        public ActionResult Details(int id)
        {
           
            ProductDAO dao = new ProductDAO();
            Product product = new Product();
            product = dao.FindById(id);
            return View(product);
        }
        public PartialViewResult catePartail()
        {
            List<category> list = new List<category>();
            CategoryService.Category_AdminClient cate = new CategoryService.Category_AdminClient();
            var lst = cate.list_cate();
            foreach(var item in lst)
            {
                category ca = new category();
                ca.idCategory = item.idCategory;
                ca.nameCategory = item.nameCategory;
                list.Add(ca);
            }
            return PartialView(list);
        }
        public ActionResult SearchBycate(int id)
        {
            List<ProductDTO> proWithCate = new List<ProductDTO>();
            var lst = pa.List_cate(id);
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
                proWithCate.Add(pro);
            }
            return View(proWithCate.ToList());
           
        }
       
    }
}