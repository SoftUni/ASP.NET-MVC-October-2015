using LaptopStore.App.Hubs;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.App.Areas.Admin.Controllers
{
    public class NotificationsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult SendNotification(string type, string notification)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationsHub>();
            hubContext.Clients.All.receiveNotification(type, notification);
            return this.Content("Notification sent.<br />");
        }
    }
}