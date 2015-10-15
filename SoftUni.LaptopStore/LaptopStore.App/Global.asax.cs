using AutoMapper;
using LaptopStore.App.App_Start;
using LaptopStore.Data;
using LaptopStore.Data.Migrations;
using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LaptopStore.App
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            MapperConfig.RegisterMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
