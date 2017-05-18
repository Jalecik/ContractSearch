namespace CodeFirstExistingDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<StudentsInformation> StudentsInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.Teachers)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .HasOptional(e => e.Faculty1)
                .WithRequired(e => e.Faculty2);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsInformation>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
