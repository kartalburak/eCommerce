using DevExpress.Web.Mvc;
using eCommerce.Entities;
using eCommerce.Interfaces;
using eCommerce.MvcWebUI.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace eCommerce.WebUI.Admin.Controller
{
    public class AdminController : System.Web.Mvc.Controller
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly IPictureService _pictureService;
        [Inject]
        public AdminController(IProductService productService, IBrandService brandService, IPictureService pictureService)
        {
            _productService = productService;
            _brandService = brandService;
            _pictureService = pictureService;
        }
        private int PageSize = 20;

        public ActionResult Index(int page = 1, int category = 0)
        {
            List<Product> products = _productService.GetAll().Where(x => x.CategoryId == category || category == 0).ToList();

            // return View(products.Skip((page - 1) * PageSize).Take(2).ToList());
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * PageSize).Take(20).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrentPage = page,
                    CurrentCategory = category
                }
            });
        }

        public ActionResult AddBrand()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBrand(Brand brnd, HttpPostedFileBase fileUpload)
        {
            if (fileUpload != null)
            {
                string path = Path.Combine(Server.MapPath("/Content/AdminUI/images/" + Guid.NewGuid() + "-" + Path.GetFileName(fileUpload.FileName)));
                fileUpload.SaveAs(path);

                Picture picture = new Picture();
                picture.MidPath = path;
                _pictureService.Add(picture);

                Brand brand = new Brand();
                brand.BrandName = brnd.BrandName;
                brand.BrandDescription = brnd.BrandDescription;
                brand.PictureId = picture.PictureId;

                _brandService.Add(brand);

            }

            return RedirectToAction("Index");
        }

        public ActionResult ListBrand()
        {
            return View("~/Views/AdminHome/ListBrand.cshtml", _brandService.GetAll());
        }

        [HttpPost]
        public ActionResult DeleteBrand(int id)
        {
            _brandService.Delete(id);
            return RedirectToAction("ListBrand");

        }

        eCommerce.Dal.Concrete.Entities.ECommerceContext db = new eCommerce.Dal.Concrete.Entities.ECommerceContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.Brand;
            return PartialView("~/Views/AdminHome/_GridViewPartial.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] eCommerce.Entities.Brand item)
        {
            var model = db.Brand;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/AdminHome/_GridViewPartial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] eCommerce.Entities.Brand item)
        {
            var model = db.Brand;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.BrandId == item.BrandId);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/AdminHome/_GridViewPartial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(System.Int32 BrandId)
        {
            var model = db.Brand;
            if (BrandId >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.BrandId == BrandId);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/AdminHome/_GridViewPartial.cshtml", model.ToList());
        }
    }
}