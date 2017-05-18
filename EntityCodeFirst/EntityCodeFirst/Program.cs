using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            AddStudent();
            Console.WriteLine("Student Saved");
            Console.ReadLine();


            }
        public static void AddStudent()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=Entity;Integrated Security=True")) ;

            using (var db = new studentContext())
            {
                var student = new Students()
                {
                    Id = 4,
                    Name = "hjsxchb",
                    Surname = "dfdddfbhdc",
                    Email = "hhddfsdcdcv"
                };
                db.Students.Add(student);
                db.SaveChanges();
            }

        }
    }
}

