using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.SiteProvider;
using KenticoMVCWidgetShowcase.Models;

namespace KenticoMVCWidgetShowcase.Services
{
    internal class HomePageService
    {
        public static HomePageViewModel GetHomePage()
        {
            // Gets the latest version of a single article using the generated provider
            HomePageViewModel vm = new HomePageViewModel();
            vm.PageInfo = HomePageProvider.GetHomePage("/home", "en-us", SiteContext.CurrentSiteName);
            return vm;
        }
    }
}