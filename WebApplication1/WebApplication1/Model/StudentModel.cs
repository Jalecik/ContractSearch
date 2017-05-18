using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace WebApplication1.Model
{
    public class StudentModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public static StudentModel Create(Student student)
        {
            StudentModel stModel = new StudentModel();
            stModel.id = student.id;
            stModel.Name = student.Name;
            stModel.Surname = student.Surname;
            stModel.Email = student.Email;
            return stModel;
        }

    }
}