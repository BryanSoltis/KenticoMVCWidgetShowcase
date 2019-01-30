using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using System.Web.Mvc;

namespace KenticoMVCWidgetShowcase.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Gets the latest version of a single article using the generated provider
            HomePage page = HomePageProvider.GetHomePage("/home", "en-us", "KenticoMVCWidgetShowcase");

            // Returns a 404 error when the retrieving is unsuccessful
            if (page == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            return View(page);
        }
    }
}
