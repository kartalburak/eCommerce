using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using eCommerce.Business.Concrete;
using eCommerce.Dal.Concrete.Entities;
using eCommerce.Dal.Concrete.Petapoco;
using eCommerce.Interfaces;
using eCommerce.WebUI.Admin.Controller;
using Ninject;

namespace eCommerce.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectControllerFactory()
         {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();//şu interface'i isterse şu sınıfı ver dicez.
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EfProductDal());
            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());
            _ninjectKernel.Bind<IBrandService>().To<BrandManager>().WithConstructorArgument("brandDal", new EfBrandDal());
            _ninjectKernel.Bind<IPictureService>().To<PictureManager>().WithConstructorArgument("pictureDal", new EfPictureDal());

            _ninjectKernel.Bind<IBrandService>().To<BrandManager>()
                .WhenInjectedInto<AdminController>()
                .WithConstructorArgument("brandDal", new PetapocoBrandDal());
            var mybrand = _ninjectKernel.Get<IBrandService>();

        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }
    }
}