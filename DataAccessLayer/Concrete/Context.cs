using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BUBEBSC; database=DbWorkTrackingProject;integrated security=true");
        }

        public DbSet<Invoice> MDY_Invoices { get; set; }
        public DbSet<Service> MDY_Services { get; set; }
        public DbSet<UserType> MDY_UserTypes { get; set; }
        public DbSet<User> MDY_Users { get; set; }
    }
}
