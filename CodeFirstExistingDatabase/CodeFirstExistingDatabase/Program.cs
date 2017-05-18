using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExistingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentModel())
            {
                var name = Console.ReadLine();

                var st = new StudentsInformation { Name = name };
                db.StudentsInformations.Add(st);
                db.SaveChanges();

                var query = from s in db.StudentsInformations
                            orderby s.Name
                            select s;

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
