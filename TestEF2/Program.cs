using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDbContext ctx = new MyDbContext();
            //Person p = new Person();
            //p.CreateDateTime = DateTime.Now;
            //p.Name = "rupeng";
            //ctx.Persons.Add(p);
            //ctx.SaveChanges();

            using (MyDbContext ctx = new MyDbContext())

            {

                ctx.Database.Log =
                    (sql) =>
                        {
                            Console.WriteLine("=============log============");
                            Console.WriteLine(sql);
                        };

                #region ef增删改查
                //for (int i = 0; i < 10; i++)
                //{
                //    Dog d = new Dog { Name = "aGan" +i};
                //    ctx.Dogs.Add(d);
                //    ctx.SaveChanges();
                //}

                //var dogs = ctx.Dogs.Where(x=>x.Id>8);
                //ctx.Dogs.RemoveRange(dogs);
                //ctx.SaveChanges();

                //var dogs = ctx.Dogs.Where(x => x.Id%2==0);
                //foreach (var dog in dogs)
                //{
                //    dog.Name += "even";

                //}
                //ctx.SaveChanges();

                //var dogs = ctx.Dogs.OrderByDescending(x => x.Id).Skip(1).Take(2);
                //foreach (var dog in dogs)
                //{
                //    Console.WriteLine(dog);
                //} 
                #endregion

                #region ef状态管理

                //Dog d = new Dog { Name="a lang"};
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.Dogs.Add(d);
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.SaveChanges();
                //Console.WriteLine(ctx.Entry(d).State);
                //d.Name = "lang lang";
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.SaveChanges();
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.Dogs.Remove(d);
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.SaveChanges();
                //Console.WriteLine(ctx.Entry(d).State);

                //Dog d = new Dog { Name = "a lang" };
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.Entry(d).State = EntityState.Added;
                //Console.WriteLine(ctx.Entry(d).State);
                //ctx.SaveChanges();
                //Console.WriteLine(ctx.Entry(d).State); 

                //Dog d =ctx.Dogs.Where(x=>x.Id==1).SingleOrDefault();
                //Console.WriteLine(ctx.Entry(d).State);
                #endregion

                //Class c1 = new Class { Name = "class3grade5" };
                //Student s1 = new Student { Name = "pipixia" };
                //Student s2 = new Student { Name = "chaojimali" };
                //s1.Class = c1;
                //s2.Class = c1;
                //ctx.Students.Add(s1);
                //ctx.Students.Add(s2);
                //ctx.Classes.Add(c1);
                //ctx.SaveChanges();

                //Console.WriteLine(ctx.Students.First().Class.Name);

                Class c1 = new Class { Name = "class2grade3" };
                Class c2 = new Class { Name = "superStudent" };
                Student s1 = new Student { Name = "papi" };
                Student s2 = new Student { Name = "wangnima" };
                s1.Class = c1;
                s1.SmallClass = c2;
                s2.Class = c1;
                

                ctx.Students.Add(s1);
                ctx.Students.Add(s2);
                ctx.Classes.Add(c1);
                ctx.Classes.Add(c2);
                ctx.SaveChanges();

            }

            Console.WriteLine("{0} successfully","operation");
            Console.ReadKey();
        }
    }
}
