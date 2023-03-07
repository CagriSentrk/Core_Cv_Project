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

            optionsBuilder.UseSqlServer("server=CSENTURK\\SQLSERVER;database=CoreCvDB;integrated security=true");
        }

        public DbSet<Bussines> Bussinesses { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Highliht> Highlihts { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contact> Contacts { get; set; }
       
      

    }
}


