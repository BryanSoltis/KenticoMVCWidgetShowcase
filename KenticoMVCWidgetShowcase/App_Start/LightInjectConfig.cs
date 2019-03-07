using KenticoMVCWidgetShowcase.Controllers.Widgets;
using KenticoMVCWidgetShowcase.LightInject;
using KenticoMVCWidgetShowcase.LightInject.Mvc;
using KenticoMVCWidgetShowcase.Repositories;
using KenticoMVCWidgetShowcase.Repositories.Implementation;
using KenticoMVCWidgetShowcase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace KenticoMVCWidgetShowcase.App_Start
{
    public static class LightInjectConfig
    {
        public static void Register()
        {
            // Register LightBox service container
            var container = new ServiceContainer();

            container.EnableMvc();

            // Register the controllers
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register the services
            container.Register<HomePageService>();
            container.Register<MVCWidgetsPageService>();
            container.Register<MVCWidgetService>();

            // Register the repositories
            container.Register<IMVCWidgetRepository, MVCWidgetRepository>();
        }
    }
}