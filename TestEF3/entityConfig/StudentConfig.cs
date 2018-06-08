using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF3.entity;

namespace TestEF3.entityConfig
{
    class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.ToTable("T_Students2");

        }
    }
}
