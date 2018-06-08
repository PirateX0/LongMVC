using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    [Table("T_Persons")]//因为类名和表名不一样，所以要使用Table标注
    public class Person
    {
        public long Id { set; get; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
    }

}
