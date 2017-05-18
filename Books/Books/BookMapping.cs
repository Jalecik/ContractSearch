using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Books.Program;

namespace Books
{
    class BookMapping : EntityTypeConfiguration<Book>
    {
        public BookMapping()
        {
            ToTable("Books");
            HasKey(s => s.Id)
           .HasRequired<Author>(s => s.Authors)
           .WithMany(b => b.Books)
           .HasForeignKey(f => f.AuthorId);
            Property(p => p.Title).HasColumnType("varchar").HasMaxLength(50);
            Property(p => p.PublishDate).HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.Price).HasColumnType("int");
            Property(p => p.Genre).HasColumnType("varchar").HasMaxLength(6);
            Property(p => p.Language).HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.EditionAmount).HasColumnType("varchar").HasMaxLength(6);
            Property(p => p.AuthorId).HasColumnType("int");


        }
    }
}
