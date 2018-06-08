using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestEF3.entityConfig;
using TestEF3.entity;


namespace TestEF3
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("conStr")
        {
            Database.SetInitializer<MyDbContext>(null);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); modelBuilder.Configurations.AddFromAssembly(
            Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Person>().ToTable("T_Persons");
            //modelBuilder.Configurations.Add(new PersonConfig());
        }

    }

}
