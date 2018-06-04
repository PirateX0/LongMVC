using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace testFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dynamic type
            //dynamic p = new ExpandoObject();
            //p.name = "dalong";

            //Person p = new Person { Name = "dalong" };

            //var a = new { p.Name, Age = 5 };

            //Console.WriteLine(a.Name + "," + a.Age);
            #endregion

            #region lambda
            //var s0 = new Student { Name = "tom", Age = 3, Gender = true, Salary = 6000 };
            //var s1 = new Student { Name = "jerry", Age = 8, Gender = true, Salary = 5000 };
            //var s2 = new Student { Name = "jim", Age = 3, Gender = true, Salary = 3000 };
            //var s3 = new Student { Name = "lily", Age = 5, Gender = false, Salary = 9000 };
            //var s4 = new Student { Name = "lucy", Age = 6, Gender = false, Salary = 2000 };
            //var s5 = new Student { Name = "kimi", Age = 5, Gender = true, Salary = 1000 };

            //List<Student> list = new List<Student>();
            //list.Add(s0);
            //list.Add(s1);
            //list.Add(s2);
            //list.Add(s3);
            //list.Add(s4);
            //list.Add(s5);
            //Teacher t1 = new Teacher { Name = "如鹏网张老师" };
            //t1.Students.Add(s1);
            //t1.Students.Add(s2);
            //Teacher t2 = new Teacher { Name = "如鹏网刘老师" };
            //t2.Students.Add(s2);
            //t2.Students.Add(s3);
            //t2.Students.Add(s5);
            //Teacher[] teachers = { t1, t2 };


            //Console.WriteLine(new List<Student> { }.Any());
            //Console.WriteLine(new List<Student> { new Student { } }.Any());
            //Console.WriteLine(list.Any(s=>s.Name=="dalong"));
            //Console.WriteLine(list.Any(s => s.Name == "tom"));

            //Console.WriteLine();

            //var orderedList = list.OrderBy(s => s.Age).ThenBy(s => s.Salary);
            //foreach (var item in orderedList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //var pagedList = list.Skip(3).Take(2);
            //foreach (var item in pagedList)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] nums = { 1,2,3,5};
            //int[] nums2 = { 3,4,5,6};
            //var nums3 = nums.Except(nums2);
            //foreach (var num in nums3)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();
            //var nums4 = nums.Union(nums2);
            //foreach (var num in nums4)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();
            //var nums5 = nums.Intersect(nums2);
            //foreach (var num in nums5)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();

            //var groupList = list.GroupBy(s => s.Age);
            //foreach (var group in groupList)
            //{
            //    Console.WriteLine("key: " + group.Key + "," + "max salary: " + group.Max(s => s.Salary));
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //IEnumerable<Student> studentList = teachers.SelectMany(t => t.Students);
            //foreach (var student in studentList)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine();

            //IEnumerable<List<Student>> studentList2 = teachers.Select(t => t.Students);
            //foreach (var student in studentList2)
            //{
            //    foreach (var item in student)
            //    {
            //        Console.WriteLine(item);
            //    }
            //} 
            #endregion

            #region linq
            //Master m1 = new Master { Id = 1, Name = "yzk" };
            //Master m2 = new Master { Id = 2, Name = "bill" };
            //Master m3 = new Master { Id = 3, Name = "zhouxingchi" };
            //Master[] masters = { m1, m2, m3 };
            //Dog d1 = new Dog { Id = 1, MasterId = 3, Name = "wangcai" };
            //Dog d2 = new Dog { Id = 2, MasterId = 3, Name = "wangwang" };
            //Dog d3 = new Dog { Id = 3, MasterId = 1, Name = "jingba" };
            //Dog d4 = new Dog { Id = 4, MasterId = 2, Name = "taidi" };
            //Dog d5 = new Dog { Id = 5, MasterId = 1, Name = "tianyuan" };

            //Dog[] dogs = { d1, d2, d3, d4, d5 };

            //var joinList = dogs.Join(masters, d => d.MasterId, m => m.Id, (d, m) => new {dogName= d.Name, masterName= m.Name });
            //foreach (var item in joinList)
            //{
            //    Console.WriteLine(item.dogName+","+item.masterName);
            //}

            //var dogList = dogs.Where(x=>x.Id>3);
            //foreach (var dog in dogList)
            //{
            //    Console.WriteLine(dog);
            //}

            //var dogList2 = from d in dogs
            //               where d.Id > 3
            //               select d;
            //foreach (var dog in dogList2)
            //{
            //    Console.WriteLine(dog);
            //}

            //var dogList3 = from d in dogs
            //               orderby d.MasterId
            //               select new { d.Id,d.Name,master=d.MasterId};
            //foreach (var dog in dogList3)
            //{
            //    Console.WriteLine(dog.Id+","+dog.master);
            //}

            //var dogList = from d in dogs
            //              join m in masters on d.MasterId equals m.Id
            //              select new { dogName=d.Name,masterName=m.Name };
            //foreach (var dog in dogList)
            //{
            //    Console.WriteLine(dog.dogName + "," + dog.masterName);
            //}


            //var dogList = from d in dogs
            //              group d by d.MasterId into g
            //              select new { masterId = g.Key, maxDogId = g.Max(d => d.Id), count = g.Count() };
            //foreach (var dog in dogList)
            //{
            //    Console.WriteLine(dog.masterId + "," + dog.maxDogId + "," + dog.count);
            //}

            //var joinList = from d in dogs
            //               join m in masters on d.MasterId equals m.Id
            //               select new { dogName = d.Name, masterName = m.Name };
            //var dogList = from j in joinList
            //              group j by j.masterName into g
            //              select g;
            //var dogList = from j in (from d in dogs
            //                        join m in masters on d.MasterId equals m.Id
            //                        select new { dogName = d.Name, masterName = m.Name })
            //              group j by j.masterName into g
            //              select g;
            //foreach (var dog in dogList)
            //{
            //    Console.WriteLine(dog.Key+","+dog.Count());
            //    foreach (var item in dog)
            //    {
            //        Console.WriteLine(item.dogName);
            //    }
            //} 
            #endregion

            Person p = new Person();
            Console.WriteLine(p);
            Console.WriteLine(nameof(p));

            int? i = null;
            Console.WriteLine(i??3);
            Console.WriteLine(i?.ToString());
            string s = null;
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; } = "dalong";
        public int Age { get; set; } = 18;
        public override string ToString()
        {
            return Name+","+Age;
        }
    }
    class Master

    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    class Dog
    {
        public long Id { get; set; }
        public long MasterId { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "The dog's name is "+Name;
        }
    }
}
