using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext ctx = new MyDbContext();
            Person p = new Person();
            p.CreateDateTime = DateTime.Now;
            p.Name = "rupeng";
            ctx.Persons.Add(p);
            ctx.SaveChanges();
            Console.WriteLine("add successfully");
            Console.ReadKey();
        }
    }
}
