using Application;
using Application.Common;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentController : ApiController
    {
        [Route("{id}")]
        [HttpGet]
        public HttpResponseMessage GetStudentById(int id)
        {
            var result = StudentService.GetStudentById(id);
            if (result != null)
            {
                StudentModel stModel = StudentModel.Create(result);
                return Request.CreateResponse(HttpStatusCode.OK,stModel);
            }
            else
            {
               var errorModel = new ErrorModel();
               errorModel.ErrorCode = 404;
               errorModel.ErrorMessage = "Daxil etdiyiniz Id-ye uygun telebe tapilmadi";
               HttpError err = new HttpError(errorModel.ErrorMessage);
               return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult DeletestudentById(int id)
        {
            var result = StudentService.DeleteStudent(id);
            switch (result.ErrorCode)
            {
                case (int)Enums.Errors.GENERAL_ERROR:
                    return new System.Web.Http.Results.ResponseMessageResult(
                    Request.CreateErrorResponse(
                        (HttpStatusCode)404,
                        new HttpError("General Error ")
                    ));
                case (int)Enums.Errors.NOT_FOUND:
                    return new System.Web.Http.Results.ResponseMessageResult(
                        Request.CreateErrorResponse(
                            (HttpStatusCode)404,
                            new HttpError("There is not student with such id ")
                        ));
                case (int)Enums.Errors.SUCCESS:
                    return new System.Web.Http.Results.ResponseMessageResult(
                        Request.CreateErrorResponse(
                            (HttpStatusCode)200,
                            new HttpError("Deleted")
                        ));
                    break;
            }
            return null;
            
        }

        [Route("{id}")]
        [HttpPut]
        public String UpdateStudentById(int id)
        {
            var result = StudentService.UpdateStudentTable(id, "ff", "ff", "ff");
            return "Updated";
        }

        [Route("")]
        [HttpGet]
        public List<StudentModel> GetallStudents()
        {
            List<StudentModel> studenModelList = new List<StudentModel>();

            var studentList = StudentService.GetallStudents();
            foreach (var student in studentList)
            {
                StudentModel studentmodel = StudentModel.Create(student);
                studenModelList.Add(studentmodel);
            }
            return studenModelList;
        }

        [Route("")]
        [HttpPost]
        public String InsertNewStudent()
        {
            var result = StudentService.InsertNewStudent("ff", "ff", "ff", new DateTime(2013, 1, 23), "vxcvf", 1233, "dfsdf", "dfsdfs", new DateTime(2013, 1, 23), new DateTime(2013, 1, 23), "dsds", 33, 2, "dfdf");
            return "Inserted";
        }
    }
}

