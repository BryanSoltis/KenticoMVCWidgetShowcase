using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using KenticoMVCWidgetShowcase.Models.MVCWidgets;
using System;
using System.Web.Mvc;

namespace KenticoMVCWidgetShowcase.Controllers
{
    public class MVCWidgetsController : Controller
    {
        // GET: MVCWidgets
        public ActionResult Index()
        {
            // Gets the latest version of a single article using the generated provider
            MVCWidgetsPage page = MVCWidgetsPageProvider.GetMVCWidgetsPage("/mvcwidgets", "en-us", "KenticoMVCWidgetShowcase");

            // Returns a 404 error when the retrieving is unsuccessful
            if (page == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            return View(page);
        }

        // GET: MVCWidgets/Show/{guid}
        public ActionResult Show(Guid guid, string pageAlias)
        {
            // Gets the latest version of a single article using the generated provider
            MVCWidgetsPage page = MVCWidgetsPageProvider.GetMVCWidgetsPage("/mvcwidgets", "en-us", "KenticoMVCWidgetShowcase");

            // Returns a 404 error when the retrieving is unsuccessful
            if (page == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            var mvcwidget = MVCWidgetProvider.GetMVCWidget(guid, "en-us", "KenticoMVCWidgetShowcase");

            if (mvcwidget == null)
            {
                return HttpNotFound();
            }

            return View(MVCWidgetViewModel.GetViewModel(mvcwidget));
        }
    }
}