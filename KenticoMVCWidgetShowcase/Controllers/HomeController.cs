using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
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

            return View(page);
        }
    }
}
