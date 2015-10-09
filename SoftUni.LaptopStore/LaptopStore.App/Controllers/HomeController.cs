namespace LaptopStore.App.Controllers
{
    using Data;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            ViewBag.Title = "Hello World!";
            var allLaptops = context.Laptops
                .OrderBy(l => l.Id);
            return View(allLaptops);
        }
    }
}