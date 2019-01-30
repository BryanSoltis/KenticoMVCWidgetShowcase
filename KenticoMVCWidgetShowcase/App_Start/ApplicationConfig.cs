using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using KenticoMVCWidgetShowcase.App_Start;
using System.Web.Optimization;

namespace KenticoMVCWidgetShowcase
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(IApplicationBuilder builder)
        {
            // Enable required Kentico features

            // Gets the ApplicationBuilder instance
            // Allows you to enable and configure Kentico MVC features
            // Enables the preview feature
            ApplicationBuilder.Current.UsePreview();

            // Enables the page builder feature
            ApplicationBuilder.Current.UsePageBuilder();
        }
    }
}