using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF3.Utility;

namespace TestEF3.entity
{
    public class Student : BaseEntity
    {
        public long  Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
