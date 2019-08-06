using eCommerce.MvcWebUI.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace eCommerce.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //bundan sonra controller'larda ninjectcontrollerfactory ile çözümle
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());


        }
    }
}
