using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IS_403_Project_1.Models;

namespace IS_403_Project_1.DAL
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