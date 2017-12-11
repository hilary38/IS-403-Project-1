using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1_IS_403.Models
{
    public class Mission
    {
        public int missID { get; set; }
        public string missName { get; set; }
        public string missPresident { get; set; }
        public string missAddress { get; set; }
        public string missLanguage { get; set; }
        public string missClimate { get; set; }
        public string missDominantReligion { get; set; }
        public string missionImg { get; set; }
    }
}