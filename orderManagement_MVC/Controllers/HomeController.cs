using orderManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace orderManagement_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Guid id)
        {
            Order order = new Order()
            {
                OrderId = Guid.NewGuid(),
                OrderName = "Kia",
                OrderDate = DateTime.Now


            };
            return View(order);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}