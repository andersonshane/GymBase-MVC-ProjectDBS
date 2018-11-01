using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GymBase_MVC_ProjectDBS.Models
{
    public class MyDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        
            //Constructor of the class
    
        public MyDbContext() : base("name=MyDbContext")
        {
        }

        public System.Data.Entity.DbSet<GymBase_MVC_ProjectDBS.Models.Booking> Bookings { get; set; }

        public System.Data.Entity.DbSet<GymBase_MVC_ProjectDBS.Models.Facilities> Facilities { get; set; }

        public System.Data.Entity.DbSet<GymBase_MVC_ProjectDBS.Models.GymClasses> GymClasses { get; set; }

        public System.Data.Entity.DbSet<GymBase_MVC_ProjectDBS.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<GymBase_MVC_ProjectDBS.Models.Trainer> Trainers { get; set; }
    }
}
