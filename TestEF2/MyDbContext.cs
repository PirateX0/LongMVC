using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestEF2.EntityConfig;


namespace TestEF2
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("conStr")
        //name=conn1表示使用连接字符串中名字为conn1的去连接数据库
        {
            Database.SetInitializer<MyDbContext>(null);
        }
        public DbSet<Person> Persons { get; set; }//通过对Persons集合的操作就可以完成对T_Persons表的操作
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); modelBuilder.Configurations.AddFromAssembly(
            Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Person>().ToTable("T_Persons");
            //modelBuilder.Configurations.Add(new PersonConfig());
        }

    }

}
