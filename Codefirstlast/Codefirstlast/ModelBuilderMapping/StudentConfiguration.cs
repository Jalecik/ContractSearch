using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirstlast.ModelBuilderMapping
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("Student");
            HasKey(s => s.Id);
            Property(p => p.Name).HasColumnName("FirstName");
        }

    }
}
