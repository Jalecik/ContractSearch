using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Books.Program;

namespace Books
{
    class AuthorMapping : EntityTypeConfiguration<Author>
    {
        public AuthorMapping()
        {
            ToTable("Authors");
            HasKey(s => s.Id);
            Property(p => p.Id).HasColumnType("int");
            Property(p => p.AuthorName).HasColumnType("varchar").HasMaxLength(30);
            Property(p => p.Email).HasColumnType("varchar").HasMaxLength(30);
        }
    }
}
