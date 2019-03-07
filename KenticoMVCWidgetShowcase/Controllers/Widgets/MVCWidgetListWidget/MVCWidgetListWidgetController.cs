﻿using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using CMS.EventLog;
using CMS.SiteProvider;
using Kentico.PageBuilder.Web.Mvc;
using KenticoMVCWidgetShowcase.Controllers.Widgets;
using KenticoMVCWidgetShowcase.Models.Widgets.MVCWidgetListWidget;
using KenticoMVCWidgetShowcase.Repositories;
using KenticoMVCWidgetShowcase.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

// Assembly attribute to register the widget for the connected Kentico instance
[assembly: RegisterWidget("KenticoMVCWidgetShowcase.Widgets.MVCWidgetListWidget", typeof(MVCWidgetListWidgetController), "MVC Widget List ", Description = "This widget allows editors to insert/edit a list of MVC widgets.", IconClass = "icon-kentico")]

namespace KenticoMVCWidgetShowcase.Controllers.Widgets
{
    public class MVCWidgetListWidgetController : WidgetController<MVCWidgetListWidgetProperties>
    {
        private readonly IMVCWidgetRepository _repository;

        /// <summary>
        /// Creates an instance of <see cref="MVCWidgetListWidgetController"/> class.
        /// </summary>
       public MVCWidgetListWidgetController(IMVCWidgetRepository repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Creates an instance of <see cref="MVCWidgetListWidgetController"/> class.
        /// </summary>
        /// <param name="propertiesRetriever">Retriever for widget properties.</param>
        /// <param name="currentPageRetriever">Retriever for current page where is the widget used.</param>
        /// <remarks>Use this constructor for tests to handle dependencies.</remarks>
        public MVCWidgetListWidgetController(IWidgetPropertiesRetriever<MVCWidgetListWidgetProperties> propertiesRetriever,
                                        ICurrentPageRetriever currentPageRetriever) : base(propertiesRetriever, currentPageRetriever)
        {
        }

        public ActionResult Index()
        {
            try
            {
                string siteName = SiteContext.CurrentSiteName;

                // Retrieves the properties as a strongly typed object
                var properties = GetProperties();

                // Get the collection of MVC Widgets
                IEnumerable<MVCWidget> mvcwidgets = _repository.GetMVCWidgets(properties.SelectTopN);

                // Creates a new model and sets its value
                var model = new MVCWidgetListWidgetViewModel
                {
                    HeaderText = properties.HeaderText,
                    IntroText = properties.IntroText,
                    MVCWidgets = mvcwidgets,
                    ShowAllLink = properties.ShowAllLink
                };

                return PartialView("Widgets/_MVCWidgetListWidget", model);
            }
            catch (Exception ex)
            {
                EventLogProvider.LogException("MVCWidgetListWidgetController", "ERROR", ex);
                return null;
            }
        }
    }
}