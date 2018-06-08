using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestEF2.EntityConfig
{
    class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            this.ToTable("T_Persons");//等价于[Table("T_Persons")]
        }
    }

}
