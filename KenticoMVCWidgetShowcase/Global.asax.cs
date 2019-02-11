using Kentico.Web.Mvc;
using KenticoMVCWidgetShowcase.App_Start;
using System.Web.Optimization;
using System.Web.Routing;

namespace KenticoMVCWidgetShowcase
{
    public class KenticoMVCWidgetShowcaseApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Enables and configures selected Kentico ASP.NET MVC integration features
            ApplicationConfig.RegisterFeatures(ApplicationBuilder.Current);

            // Register the script bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Registers routes including system routes for enabled features
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
