using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("conStr")
        //name=conn1表示使用连接字符串中名字为conn1的去连接数据库
        {
        }
        public DbSet<Person> Persons { get; set; }//通过对Persons集合的操作就可以完成对T_Persons表的操作
    }

}
