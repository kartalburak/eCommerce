using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Business.Concrete;
using eCommerce.Dal.Concrete.Entities;
using eCommerce.Dal.Concrete.Petapoco;
using eCommerce.Entities;
using eCommerce.Interfaces;
using eCommerce.MvcWebUI.Models;
using Ninject;

namespace eCommerce.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        //private readonly ProductManager _productManager = new ProductManager(new EfProductDal());
        //private IProductService _productService = new ProductManager(new EfProductDal());

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        private int PageSize = 2;
        /*
        public ViewResult Index(int page = 1)   //querystring,hiddenfield'da page arar.model binding//int page = 1 ile default değer verdik.
        {
            //List<Product> products = _productManager.GetAll();
            List<Product> products = _productService.GetAll().Skip((page - 1) * PageSize).Take(5).ToList(); // 5'erli listeler.
            return View(products);
        }*/
        //category=0 ise tüm ürünler gelir.
        public ViewResult ListProduct(int page = 1, int category = 0)
        {

            ViewBag.Category = _categoryService.GetAll();


            List<Product> products = _productService.GetAll().Where(x => x.CategoryId == category || category == 0).ToList();
            // return View(products.Skip((page - 1) * PageSize).Take(2).ToList());
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * PageSize).Take(2).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrentPage = page,
                    CurrentCategory = category
                }
            });
        }


    }
}