namespace LaptopStore.App.Controllers
{
    using Data;
    using System.Web.Mvc;

    public class LaptopsController : Controller
    {
        public ActionResult Details(int id)
        {
            var context = new ApplicationDbContext();
            var laptop = context.Laptops.Find(id);
            if (laptop == null)
            {
                return this.HttpNotFound();
            }

            return View(laptop);
        }
    }
}