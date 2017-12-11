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
        public int missId { get; set; }

        [DisplayName("Mission Name")]
        [Required(ErrorMessage = "A mission name is required")]
        public string missName { get; set; }

        [DisplayName("Mission President First Name")]
        [Required(ErrorMessage = "A mission president first name is required")]
        public string missPresidentFirstName { get; set; }

        [DisplayName("Mission President Last Name")]
        [Required(ErrorMessage = "A mission president first name is required")]
        public string missPresidentLastName { get; set; }

        [DisplayName("Mission Address")]
        [Required(ErrorMessage = "A mission address is required")]
        public string missAddressLine1 { get; set; }

        [DisplayName("Mission Address")]
        public string missAddressLine2 { get; set; }

        [DisplayName("Mission Zip")]
        [Required(ErrorMessage = "A mission address is required")]
        public string missZip { get; set; }

        [DisplayName("Mission Address")]
        [Required(ErrorMessage = "A mission address is required")]
        public string missCity { get; set; }

        [DisplayName("Mission Address")]
        [Required(ErrorMessage = "A mission address is required")]
        public string missState { get; set; }

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