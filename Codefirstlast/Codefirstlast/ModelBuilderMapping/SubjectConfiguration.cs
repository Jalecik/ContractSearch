using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirstlast.ModelBuilderMapping
{
   public  class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {
            ToTable("Subject");
            HasKey(t => t.SubjectId)
           .HasRequired<Student>(s => s.Student)
           .WithMany(sb => sb.Subjects)
           .HasForeignKey(f => f.StudentId);
        }

    }
}
