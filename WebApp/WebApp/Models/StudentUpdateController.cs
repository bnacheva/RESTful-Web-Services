using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Models
{
    public class StudentUpdateController : ApiController
    {
        public String PutStudentRecord(Student stdn)
        {
            Console.WriteLine("In updateStudentRecord");
            return StudentRegistration.getInstance().UpdateStudent(stdn);
        }
    }
}
