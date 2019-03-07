using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.Helpers;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KenticoMVCWidgetShowcase.Services
{
    public class MVCWidgetService
    {
        public static MVCWidget GetMVCWidget(Guid guid)
        {
            string culture = "en-us";
            string siteName = SiteContext.CurrentSiteName;

            Func<MVCWidget> dataLoadMethod = () => MVCWidgetProvider.GetMVCWidget(guid, culture, siteName)
                                                                .TopN(1)
                                                                .FirstOrDefault();

            var cacheSettings = new CacheSettings(10, siteName + "|data|mvcwidget", guid, culture, siteName)
            {
                GetCacheDependency = () =>
                {
                    // Creates cache dependencies. This example makes the cache clear the data when the specified article is modified in Kentico (any culture version).
                    string dependencyCacheKey = String.Format("nodeguid|{0}|{1}", siteName, guid);
                    return CacheHelper.GetCacheDependency(dependencyCacheKey);
                }
            };

            return CacheHelper.Cache(dataLoadMethod, cacheSettings);
        }

        public static IEnumerable<MVCWidget> GetMVCWidgets(int SelectTopN)
        {
            string culture = "en-us";
            string siteName = SiteContext.CurrentSiteName;

            Func<IEnumerable<MVCWidget>> dataLoadMethod = () => MVCWidgetProvider.GetMVCWidgets()
                .OnSite(SiteContext.CurrentSiteName)
                .Culture("en-us")
                .TopN(SelectTopN)
                .OrderByDescending("DocumentPublishFrom")
                .TypedResult; // Ensures that the result of the query is saved, not the query itself

            var cacheSettings = new CacheSettings(10, siteName + "|data|mvcwidgets", siteName, culture, SelectTopN)
            {
                GetCacheDependency = () =>
                {
                    // Creates caches dependencies. This example makes the cache clear data when any article is modified, deleted, or created in Kentico.
                    string dependencyCacheKey = String.Format("nodes|{0}|{1}|all", siteName, MVCWidget.CLASS_NAME.ToLowerInvariant());
                    return CacheHelper.GetCacheDependency(dependencyCacheKey);
                }
            };

            return CacheHelper.Cache(dataLoadMethod, cacheSettings);
        }
    }
}