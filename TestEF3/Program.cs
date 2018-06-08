using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF3.entity;
using TestEF3.Utility;
using System.Data.Entity;

namespace TestEF3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher t1 = new Teacher();
            //t1.Name = "teachZhang";
            //Teacher t2 = new Teacher();
            //t2.Name = "teacherWang";
            //Student s1 = new Student();
            //s1.Name = "tom";
            //Student s2 = new Student();
            //s2.Name = "jerry";
            //Student s3 = new Student { Name="rabbit"};

            using (MyDbContext ctx=new MyDbContext())
            {
                //t1.Students.Add(s1);
                //t1.Students.Add(s2);
                //t2.Students.Add(s2);
                //t2.Students.Add(s3);

                //ctx.Teachers.Add(t1);
                //ctx.Teachers.Add(t2);

                //ctx.SaveChanges();

                //ctx.Database.Log = sql => { Console.WriteLine("=========log======="); Console.WriteLine(sql); };

                //Student student = ctx.Students.Include(nameof(Student.Teachers)).FirstOrDefault();
                //Console.WriteLine(student.GetType());
                //Console.WriteLine(student.Teachers.FirstOrDefault().Name);

                string s = "dalong";
                Console.WriteLine(s.CutHead());

                var pagedStudents= ctx.Students.GetPage(2, 1);
                var selectStudent= ctx.Students.GetById(3);
                
                

                foreach (var student in pagedStudents)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine("=====");
                Console.WriteLine(selectStudent.Name + "," + selectStudent.Id);

            }

            Console.WriteLine("ok");
            Console.ReadKey();

            

        }
    }
}
