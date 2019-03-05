using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KenticoMVCWidgetShowcase.Services
{
    internal class MVCWidgetService
    {
        public static MVCWidget GetMVCWidget(Guid guid)
        {
            MVCWidget widget = MVCWidgetProvider.GetMVCWidget(guid, "en-us", SiteContext.CurrentSiteName);
            return widget;
        }

        public static IEnumerable<MVCWidget> GetMVCWidgets(int intSelectTopN)
        {
            // Get the collection of MVC Widgets
            IEnumerable<MVCWidget> mvcwidgets = MVCWidgetProvider.GetMVCWidgets()
                .OnSite(SiteContext.CurrentSiteName)
                .Culture("en-us")
                .TopN(intSelectTopN)
                .OrderByDescending("DocumentPublishFrom")
                .TypedResult; // Ensures that the result of the query is saved, not the query itself

            return mvcwidgets;
        }
    }
}