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
            List<SelectListItem> mission = new List<SelectListItem>();
            mission.Add(new SelectListItem { Text = "Florida Jacksonville Mission", Value = "0", Selected = true });
            mission.Add(new SelectListItem { Text = "San Antonio Texas Mission", Value = "1" });
            mission.Add(new SelectListItem { Text = "California Oakland/San Francisco Mission", Value = "2" });
            ViewBag.contentType = mission;
            return View();
        }
        public ActionResult MissionFAQ(string contentType)
        {
            if (contentType.Equals("0"))
            {
                ViewBag.Mission = "Florida Jacksonville Mission";
            }
            else if (contentType.Equals("1"))
            {
                ViewBag.Mission = "San Antonio Texas Mission";
            }
            else if (contentType.Equals("2"))
            {
                ViewBag.Mission = "California Oakland/San Francisco Mission";
            }

            return View();
        }
    }
}