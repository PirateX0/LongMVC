using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFeatures
{
    class Teacher
    {
        public Teacher()
        {
            this.Students = new List<Student>();
        }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

    }
}
