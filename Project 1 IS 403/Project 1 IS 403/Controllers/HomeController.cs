using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1_IS_403.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our inspiration.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            List<SelectListItem> type = new List<SelectListItem>();
            type.Add(new SelectListItem { Text = "Question", Value = "0", Selected = true });
            type.Add(new SelectListItem { Text = "Request a page for a mission", Value = "1" });
            type.Add(new SelectListItem { Text = "Suggestion", Value = "2" });
            type.Add(new SelectListItem { Text = "Report a issue", Value = "3" });
            ViewBag.contentType = type;            
            return View();
        }
    }
}