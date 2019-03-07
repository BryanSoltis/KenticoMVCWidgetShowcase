using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using KenticoMVCWidgetShowcase.Services;

namespace KenticoMVCWidgetShowcase.Repositories.Implementation
{
    public sealed class MVCWidgetRepository : IMVCWidgetRepository
    {
        public MVCWidget GetMVCWidget(Guid guid)
        {
            return MVCWidgetService.GetMVCWidget(guid);
        }

        public IEnumerable<MVCWidget> GetMVCWidgets(int intSelectTopN = 0)
        {
            // Get the collection of MVC Widgets
            return MVCWidgetService.GetMVCWidgets(intSelectTopN);
        }
    }
}