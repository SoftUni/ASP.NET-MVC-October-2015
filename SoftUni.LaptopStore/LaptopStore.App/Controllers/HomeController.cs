namespace LaptopStore.App.Controllers
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var context = new ApplicationDbContext();
            //var allLaptops = context.Laptops
            //    .OrderBy(l => l.Id);
            //return View(allLaptops);
            return View(new TestModel[] { new TestModel() });
        }

        public ActionResult Test(TestModel[] testModels)
        {
            return Json(testModels, JsonRequestBehavior.AllowGet);
        }
    }
}