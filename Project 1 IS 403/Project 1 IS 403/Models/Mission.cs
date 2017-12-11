using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_1_IS_403.Models
{
    public class Mission
    {
        [Key]
        [DisplayName("Mission ID")]
        [Required(ErrorMessage ="A mission ID is required")]
        public int missID { get; set; }

        [DisplayName("Mission Name")]
        [Required(ErrorMessage = "A mission name is required")]
        public string missName { get; set; }

        [DisplayName("Mission President")]
        [Required(ErrorMessage = "A mission president is required")]
        public string missPresident { get; set; }

        [DisplayName("Mission Address")]
        [Required(ErrorMessage = "A mission ID is required")]
        public string missAddress { get; set; }

        [DisplayName("Mission Language")]
        [Required(ErrorMessage = "A mission language is required")]
        public string missLanguage { get; set; }

        [DisplayName("Mission Climate")]
        [Required(ErrorMessage = "A mission climate is required")]
        public string missClimate { get; set; }

        [DisplayName("Dominant Religion")]
        [Required(ErrorMessage = "A dominant religion is required")]
        public string missDominantReligion { get; set; }

        [DisplayName("Mission Image")]
        public string missionImg { get; set; }
    }
}