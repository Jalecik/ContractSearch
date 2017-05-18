using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class DeleteStudentOutput
    {
        public int Id { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}