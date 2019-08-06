using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Entities;
using eCommerce.Interfaces;


namespace eCommerce.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: Cart
        public RedirectToRouteResult AddtoCart(int productId)
        {

            Product product = _productService.Get(productId);//sepetteki ürün
            

            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddtoCart(product, 1);


            return RedirectToAction("Index","Cart", cart);



        }

        public ViewResult Index()
        {
            var cart = (Cart)Session["cart"];
            return View(cart);
        }

        public RedirectToRouteResult RemoveFromCart(int productId)
        {
            Product product = _productService.Get(productId);


            var cart = (Cart)Session["cart"];
            //if (cart.Lines.Count == 0)
            //{
            //    ModelState.AddModelError("","Sepette zaten ürün yok");
            //}
            //else
            //{
            cart.RemoveFromCart(product);
            // }
            return RedirectToAction("Index", cart);



        }




    }
}