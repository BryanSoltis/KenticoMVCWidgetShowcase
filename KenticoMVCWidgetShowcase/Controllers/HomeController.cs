using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.SiteProvider;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using KenticoMVCWidgetShowcase.Models;
using KenticoMVCWidgetShowcase.Services;
using System.Web.Mvc;

namespace KenticoMVCWidgetShowcase.Controllers
{
    public class HomeController : Controller
    {
        private HomePageService _service;

        public HomeController(HomePageService service)
        {
            this._service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            HomePageViewModel vm = _service.GetHomePage();

            // Returns a 404 error when the retrieving is unsuccessful
            if (vm.PageInfo == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(vm.PageInfo.DocumentID);

            return View(vm);
        }
    }
}