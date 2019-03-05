using KenticoMVCWidgetShowcase.LightInject;
using KenticoMVCWidgetShowcase.LightInject.Mvc;
using KenticoMVCWidgetShowcase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KenticoMVCWidgetShowcase.App_Start
{
    public static class LightInjectConfig
    {

        public static void Register()
        {
            // Register LightBox service container
            var container = new ServiceContainer();

            // Register the controllers
            container.RegisterControllers();

            // Register the services
            container.Register<HomePageService>();
            container.Register<MVCWidgetsPageService>();
            container.Register<MVCWidgetService>();
        }        
    }
}