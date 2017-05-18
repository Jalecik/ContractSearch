using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC.Models;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PersonsController :Controller
    {
        [System.Web.Mvc.Route("Persons/all")]
        public ActionResult GetPersons()
        {
            List<Persons> personList = new List<Persons>();
            var person1 = new Persons { Id = 1, Name = "AAAAAA", Surname = "bbbb", NickName = "qqqqq", Age = 23 };
            var person2 = new Persons() { Id = 2, Name = "AAAAAAbbb", Surname = "bbbb", NickName = "qqqqq", Age = 23 };
            var person3 = new Persons() { Id = 3, Name = "AAAAAAccc", Surname = "bbbb", NickName = "qqqqq", Age = 23 };
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            return View(personList);
        }

        [System.Web.Mvc.Route("Persons/{id}")]
        public ActionResult GetPersonById(int id)
        {

            List<Persons> personList = new List<Persons>();
            var person1 = new Persons { Id = 1, Name = "AAAAAA", Surname = "bbbb", NickName = "qqqqq", Age = 23 };
            var person2 = new Persons() { Id = 2, Name = "AAAAAAbbb", Surname = "bbbb", NickName = "qqqqq", Age = 23 };
            var person3 = new Persons() { Id = 3, Name = "AAAAAAccc", Surname = "bbbb", NickName = "qqqqq", Age = 23 };
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            var person = personList.First(a => a.Id == id);
            return View(person);

            }
        }
    }
