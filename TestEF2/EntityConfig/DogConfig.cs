using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF2.EntityConfig
{
    class DogConfig : EntityTypeConfiguration<Dog>
    {
        public DogConfig()
        {
            this.ToTable("T_Dogs");
        }
    }
}
