using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentRegistrationController : ApiController
    {
        public StudentRegistrationReply registerStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return stdregreply;
        }

    }
}
