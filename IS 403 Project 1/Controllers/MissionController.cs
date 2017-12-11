using IS_403_Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;    

//Controller to handle the mission view, mission FAQ view

namespace IS_403_Project_1.Controllers
    {

    public class MissionController : Controller
    {
        static Mission oMission = new Mission();
        // GET: Mission
        public ActionResult Missions()
        {
            //Adds missions to the controller for the user to select from

            List<SelectListItem> mission = new List<SelectListItem>();
            mission.Add(new SelectListItem { Text = "Florida Jacksonville Mission", Value = "0", Selected = true });
            mission.Add(new SelectListItem { Text = "San Antonio Texas Mission", Value = "1" });
            mission.Add(new SelectListItem { Text = "California Oakland/San Francisco Mission", Value = "2" });
            ViewBag.contentType = mission;
            return View();
        }

        public ActionResult MissionFAQ(string contentType)
        {
            //method to pass specific mission details to view depending on the mission. Receives a parameter of mission

            //if (contentType.Equals("0"))
            //{
            //    oMission.missName = "Florida Jacksonville Mission";
            //    oMission.missPresident = "Brother Jackson";
            //    oMission.missAddress = "555 Palm Tree Lane, Jacksonville, Florida";
            //    oMission.missLanguage = "Portugese";
            //    oMission.missClimate = "Hot and muggy!";
            //    oMission.missDominantReligion = "Southern Baptist";
            //    oMission.missionImg = "~/Content/Images/fjm.jpg";
            //    ViewBag.ImageUrl = "fjm.jpg";
            //}
            //else if (contentType.Equals("1"))
            //{
            //    oMission.missName = "San Antonio Texas Mission";
            //    oMission.missPresident = "Brother Antonio";
            //    oMission.missAddress = "555 No Tree Lane, San Antonio, Texas";
            //    oMission.missLanguage = "Spanish";
            //    oMission.missClimate = "Hot and dry!";
            //    oMission.missDominantReligion = "They're all athiests.";
            //    oMission.missionImg = "~/Content/Images/san_antonio_texas_mission.png";
            //}
            //else if (contentType.Equals("2"))
            //{
            //    oMission.missName = "California Oakland/ San Francisco Mission";
            //    oMission.missPresident = "Brother Oakland";
            //    oMission.missAddress = "555 Palm Tree Lane, San Francisco, California";
            //    oMission.missLanguage = "English";
            //    oMission.missClimate = "Hot and dryyyyyyyyyy!";
            //    oMission.missDominantReligion = "They're all athiests.";
            //    oMission.missionImg = "~/Content/Images/oakland.png";
            //}

            return View(oMission);
        }

    }
}