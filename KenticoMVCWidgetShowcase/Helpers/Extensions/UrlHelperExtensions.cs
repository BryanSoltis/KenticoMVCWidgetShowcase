using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using KenticoMVCWidgetShowcase.Models.MVCWidgets;
using System.Web.Mvc;

namespace KenticoMVCWidgetShowcase.Helpers
{
    /// <summary>
    /// Extension methods for <see cref="UrlHelper"/> class.
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Generates a fully qualified URL to the action method handling the detail of the given MVC widget.
        /// </summary>
        /// <param name="urlHelper">URL Helper</param>
        /// <param name="mvcwidget">MVC WIdget model to generate URL for.</param>
        public static string ForMVCWidget(this UrlHelper urlHelper, MVCWidget mvcwidget)
        {
            return urlHelper.Action("Show", "MVCWidgets", new
            {
                guid = mvcwidget.NodeGUID,
                pageAlias = mvcwidget.NodeAlias
            });
        }
    }
}