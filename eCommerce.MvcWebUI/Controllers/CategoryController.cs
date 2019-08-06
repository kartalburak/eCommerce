using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Entities;
using eCommerce.Interfaces;

namespace eCommerce.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;
        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

      





        public PartialViewResult CategoryList(int category = 0)
        {

            ViewBag.CurrentCategory = category;



            return PartialView(_categoryService.GetAll());
        }        

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult AddCategory(Category category)
        {

            _categoryService.Add(category);

            return View();

        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteCategory(int id)
        {

            _categoryService.Delete(id);

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult UpdateCategory(Category category)
        {
            if (category != null)
            {
                Category updatedCategory = _categoryService.Get(category.CategoryId);
                updatedCategory.CategoryDescription = category.CategoryDescription;
                updatedCategory.CategoryName = category.CategoryName;
                updatedCategory.PictureId = category.PictureId;

                _categoryService.Update(updatedCategory);





            }
            return View();
        }


        public ActionResult Index()
        {

            


            ViewBag.Categories = _categoryService.GetAll();
            

            return View(_productService.GetAll());
        }


     
    }
}