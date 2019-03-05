using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using System;

namespace KenticoMVCWidgetShowcase.Models.MVCWidgets
{
    public class MVCWidgetViewModel
    {
        public string MVCWidgetName { get; set; }

        public DateTime MVCWidgetReleaseDate { get; set; }

        public string MVCWidgetAuthor { get; set; }

        public string MVCWidgetDescription { get; set; }

        public string MVCWidgetScreenshot { get; set; }

        public string MVCWidgetPackage { get; set; }

        public Guid NodeGUID { get; set; }

        public string NodeAlias { get; set; }

        public static MVCWidgetViewModel GetViewModel(MVCWidget mvcwidget)
        {
            return new MVCWidgetViewModel
            {
                NodeAlias = mvcwidget.NodeAlias,
                NodeGUID = mvcwidget.NodeGUID,
                MVCWidgetReleaseDate = mvcwidget.MVCWidgetReleaseDate,
                MVCWidgetPackage = mvcwidget.MVCWidgetPackage,
                MVCWidgetScreenshot = mvcwidget.MVCWidgetScreenshot,
                MVCWidgetDescription = mvcwidget.MVCWidgetDescription,
                MVCWidgetAuthor = mvcwidget.MVCWidgetAuthor,
                MVCWidgetName = mvcwidget.MVCWidgetName
            };
        }
    }
}