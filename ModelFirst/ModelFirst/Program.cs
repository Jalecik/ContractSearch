using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var cont = new UniversityEntities())
            {
                var result = cont.StudentsInformations;
                foreach (var student in result)
                {
                    Console.WriteLine("id:"  + " "+student.Id);
                    Console.WriteLine("name:"+ " "+ student.Name);
                    Console.WriteLine("surname:"+ " " + student.Surname);
                    Console.WriteLine("gender:"+ " " +student.Gender);
                    Console.WriteLine("birthdate:" + " " + student.Birthdate);
                    Console.WriteLine("email:" + " " + student.Email);
                    Console.WriteLine("phone:" + " " + student.Phone);
                    Console.WriteLine("country:" + " " + student.Country);
                    Console.WriteLine("city:" + " " + student.City);
                    Console.WriteLine("--------------------------------------------------------------");
                }
                Console.ReadKey();
            }
        }
    }
}
