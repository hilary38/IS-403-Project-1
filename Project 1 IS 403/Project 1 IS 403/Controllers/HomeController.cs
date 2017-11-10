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
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            List<SelectListItem> type = new List<SelectListItem>();
            type.Add(new SelectListItem { Text = "GENERAL QUESTION", Value = "0", Selected = true });
            type.Add(new SelectListItem { Text = "REQUEST A PAGE FOR A MISSION", Value = "1" });
            type.Add(new SelectListItem { Text = "SUGGESTION", Value = "2" });
            type.Add(new SelectListItem { Text = "REPORT A ISSUE", Value = "3" });
            ViewBag.contentType = type;            
            return View();
        }
    }
}