using Project_1_IS_403.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1_IS_403.Controllers
{

    public class MissionController : Controller
    {
        static Mission oMission = new Mission();
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
                oMission.missName = "Florida Jacksonville Mission";
                oMission.missPresident = "Brother Jackson";
                oMission.missAddress = "555 Palm Tree Lane, Jacksonville, Florida";
                oMission.missLanguage = "Portugese";
                oMission.missClimate = "Hot and muggy!";
                oMission.missDominantReligion = "They're all athiests.";
                oMission.missionImg = "C:\\Users\\hilar\\Source\\Repos\\IS-403-Project-1\\Project 1 IS 403\\Project 1 IS 403\\Content\\Images\\Florida Jacksonville Mission.jpg";
            }
            else if (contentType.Equals("1"))
            {
                oMission.missName = "San Antonio Texas Mission";
                oMission.missPresident = "Brother Antonio";
                oMission.missAddress = "555 No Tree Lane, San Antonio, Texas";
                oMission.missLanguage = "Spanish";
                oMission.missClimate = "Hot and dry!";
                oMission.missDominantReligion = "They're all athiests.";
                oMission.missionImg = "C:\\Users\\hilar\\Source\\Repos\\IS-403-Project-1\\Project 1 IS 403\\Project 1 IS 403\\Content\\Images\\san_antonio_texas_mission.png";
            }
            else if (contentType.Equals("2"))
            {
                oMission.missName = "California Oakland/ San Francisco Mission";
                oMission.missPresident = "Brother Oakland";
                oMission.missAddress = "555 Palm Tree Lane, San Francisco, California";
                oMission.missLanguage = "English";
                oMission.missClimate = "Hot and dryyyyyyyyyy!";
                oMission.missDominantReligion = "They're all athiests.";
                oMission.missionImg = "C:\\Users\\hilar\\Source\\Repos\\IS-403-Project-1\\Project 1 IS 403\\Project 1 IS 403\\Content\\Images\\oakland.png";
            }

            return View(oMission);
        }
    }
}