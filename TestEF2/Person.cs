using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF2
{
    
    public class Person
    {
        public long Id { set; get; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
    }

}
