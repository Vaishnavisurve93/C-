using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using BloggingSystem.Data; // Replace with your actual namespace

namespace BloggingSystem // Replace with your actual namespace
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Configure the database initializer
            // Choose one of the following initializers:

            // This will always drop and recreate the database every time the application starts
            Database.SetInitializer(new BloggingContextInitializer());

            // Or, use this to only drop and recreate the database if the model changes
            // Database.SetInitializer(new BloggingContextInitializerIfModelChanges());

            // Other application startup configuration
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
