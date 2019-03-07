using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.Helpers;
using CMS.SiteProvider;
using KenticoMVCWidgetShowcase.Models;
using System;
using System.Collections.Generic;

namespace KenticoMVCWidgetShowcase.Services
{
    public class HomePageService
    {
        public HomePageViewModel GetHomePage()
        {
            HomePageViewModel vm = new HomePageViewModel();

            string culture = "en-us";
            string siteName = SiteContext.CurrentSiteName;

            Func<HomePage> dataLoadMethod = () => HomePageProvider.GetHomePage("/home", culture, SiteContext.CurrentSiteName);

            var cacheSettings = new CacheSettings(10, siteName + "|data|homepage", siteName, culture)
            {
                GetCacheDependency = () =>
                {
                    // Creates caches dependencies. This example makes the cache clear data when any article is modified, deleted, or created in Kentico.
                    string dependencyCacheKey = String.Format("nodes|{0}|{1}|all", siteName, HomePage.CLASS_NAME.ToLowerInvariant());
                    return CacheHelper.GetCacheDependency(dependencyCacheKey);
                }
            };

            vm.PageInfo = CacheHelper.Cache(dataLoadMethod, cacheSettings);            
            return vm;
        }
    }
}