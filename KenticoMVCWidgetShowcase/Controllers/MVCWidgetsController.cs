﻿using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using KenticoMVCWidgetShowcase.Models;
using KenticoMVCWidgetShowcase.Models.MVCWidgets;
using KenticoMVCWidgetShowcase.Services;
using System;
using System.Web.Mvc;

namespace KenticoMVCWidgetShowcase.Controllers
{
    public class MVCWidgetsController : Controller
    {
        // GET: MVCWidgets
        public ActionResult Index()
        {

            MVCWidgetsPageViewModel vm = MVCWidgetsPageService.GetMVCWidgetsPage();

            // Returns a 404 error when the retrieving is unsuccessful
            if (vm.PageInfo == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(vm.PageInfo.DocumentID);

            return View(vm);
        }

        // GET: MVCWidgets/Show/{guid}
        public ActionResult Show(Guid guid, string pageAlias)
        {
            MVCWidgetsPageViewModel vm = MVCWidgetsPageService.GetMVCWidgetsPage();

            // Returns a 404 error when the retrieving is unsuccessful
            if (vm.PageInfo == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(vm.PageInfo.DocumentID);

            var mvcwidget = MVCWidgetService.GetMVCWidget(guid);

            if (mvcwidget == null)
            {
                return HttpNotFound();
            }

            return View(MVCWidgetViewModel.GetViewModel(mvcwidget));
        }
    }
}