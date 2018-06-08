using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF2
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ClassId { get; set; }
        public long? SmallClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Class SmallClass { get; set; }
    }
}
