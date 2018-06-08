using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF3.Utility;

namespace TestEF3.entity
{
    public class Teacher: BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
