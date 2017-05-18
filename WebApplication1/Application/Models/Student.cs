using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public  string Gender { get; set; }
        public DateTime  Birthdate { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime EnteringYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public string group { get; set; }
        public int Averagemark { get; set; }
        public int FacultyId { get; set; }
        public string Status { get; set; }
    }
}