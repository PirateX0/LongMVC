using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF2
{
    public class Dog
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "id: "+Id+", name: "+Name;
        }
    }
}
