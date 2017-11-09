using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1_IS_403.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Missions()
        {
            return View();
        }
        public ActionResult MissionFAQ()
        {
            return View();
        }
    }
}