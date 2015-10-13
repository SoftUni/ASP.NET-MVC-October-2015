namespace LaptopStore.App.Controllers
{
    using Data;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            var allLaptops = context.Laptops
                .OrderBy(l => l.Id);
            return View(allLaptops);
        }
    }
}