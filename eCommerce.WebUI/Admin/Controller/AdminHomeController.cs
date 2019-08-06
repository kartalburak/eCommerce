using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PetaPoco;

namespace eCommerce.WebUI.Admin.Controller
{
    public class AdminHomeController : System.Web.Mvc.Controller
    {
        // GET: AdminHome
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult AddBrand()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult AddBrand(Brand brnd, HttpPostedFileBase fileUpload)
        //{
        //    if (fileUpload != null)
        //    {
        //        string path = Path.Combine(Server.MapPath("/Content/AdminUI/images/" + Guid.NewGuid() + "-" + Path.GetFileName(fileUpload.FileName)));
        //        fileUpload.SaveAs(path);

        //        Picture picture = new Picture();
        //        picture.MidPath = path;
        //        StaticContext.db.Insert(picture);

        //        Brand brand = new Brand();
        //        brand.BrandName = brnd.BrandName;
        //        brand.BrandDescription = brnd.BrandDescription;
        //        brand.PictureId = picture.PictureId;
        //        StaticContext.db.Insert(brand);
        //    }

        //    return RedirectToAction("Index");
        //}

        //public ActionResult ListBrand()
        //{
        //    var sql = Sql.Builder.Append("select * from Brand");
        //    IEnumerable<Brand> brands = StaticContext.db.Query<Brand>(sql.ToString());
        //    return View(brands);
        //}

        //[HttpPost]
        //public ActionResult DeleteBrand(int id)
        //{
        //    StaticContext.db.Delete(new Brand().GetBrandById(id));
        //    return RedirectToAction("ListBrand");
        //}
    }
}