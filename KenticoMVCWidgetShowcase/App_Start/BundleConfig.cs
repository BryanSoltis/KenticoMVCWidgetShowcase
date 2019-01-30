using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace KenticoMVCWidgetShowcase.App_Start
{
    /// <summary>
    /// Bundle configuration for application.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Register bundles to given <paramref name="bundles"/> collection.
        /// </summary>
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterThemeJSBundle(bundles);
        }
        
        private static void RegisterThemeJSBundle(BundleCollection bundles)
        {
            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptBndl = new ScriptBundle("~/bundles/themejs");
            
            //use Include() method to add all the script files with their paths 
            scriptBndl.Include(
                                "~/content/assets/js/jquery.min.js",
                                "~/content/assets/js/browser.min.js",
                                "~/content/assets/js/breakpoints.min.js",
                                "~/content/assets/js/util.js",
                                "~/content/assets/js/main.js"
                              );

            //Add the bundle into BundleCollection
            bundles.Add(scriptBndl);
        }
    }
}