using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF3.entity;

namespace TestEF3.entityConfig
{
    class TeacherConfig: EntityTypeConfiguration<Teacher>
    {
        public TeacherConfig()
        {
            this.ToTable("T_Teachers2");
            this.HasMany(t => t.Students).WithMany(s => s.Teachers)
                .Map(c => c.ToTable("T_TeacherStudentRelations").MapLeftKey("TeacherId").MapRightKey("StudentId"));
        }
    }
}
