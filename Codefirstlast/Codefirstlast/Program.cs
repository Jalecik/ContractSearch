using Codefirstlast.ModelBuilderMapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirstlast
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var studentsDb = new StudentContext())
            {
                var student = new Student() { Name = "Jaleeeee" };

                var math = new Subject() { Name = "Matheeeeeematics" };
                var science = new Subject() { Name = "Someeeeeeeething" };

                student.Subjects.Add(math);
                student.Subjects.Add(science);
                studentsDb.Students.Add(student);
                studentsDb.SaveChanges();
            }
            Console.WriteLine("saved");
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }
    }
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentContext")
        {

        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new SubjectConfiguration());
        }
    }
}

