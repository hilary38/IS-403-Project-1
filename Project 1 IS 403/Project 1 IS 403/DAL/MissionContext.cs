using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1_IS_403.Models;
using Sytem.Data.Entity;


namespace Project_1_IS_403.DAL
{
    public class MissionContext : DbContext
    {
        public MissionContext() : base("MissionContext")
        {

        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Question> MissionQuestions { get; set; }
        
    }
}