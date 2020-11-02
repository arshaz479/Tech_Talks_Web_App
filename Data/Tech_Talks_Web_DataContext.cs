using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tech_Talks_Web_App.Business;

namespace Tech_Talks_Web_App.Models
{
    //Connects the databse with the business model classes
    public class Tech_Talks_Web_DataContext : DbContext
    {
        public Tech_Talks_Web_DataContext (DbContextOptions<Tech_Talks_Web_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Tech_Talks_Web_App.Business.Discussion> Discussion { get; set; }

        public DbSet<Tech_Talks_Web_App.Business.Schedule> Schedule { get; set; }

        public DbSet<Tech_Talks_Web_App.Business.Speaker> Speaker { get; set; }

        public DbSet<Tech_Talks_Web_App.Business.Sponsor> Sponsor { get; set; }
    }
}
