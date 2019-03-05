using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.SiteProvider;
using KenticoMVCWidgetShowcase.Models;

namespace KenticoMVCWidgetShowcase.Services
{
    internal class MVCWidgetsPageService
    {
        public static MVCWidgetsPageViewModel GetMVCWidgetsPage()
        {
            // Gets the latest version of a single article using the generated provider
            MVCWidgetsPageViewModel vm = new MVCWidgetsPageViewModel();
            vm.PageInfo = MVCWidgetsPageProvider.GetMVCWidgetsPage("/mvcwidgets", "en-us", SiteContext.CurrentSiteName);
            return vm;
        }
    }
}