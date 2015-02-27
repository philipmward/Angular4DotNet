using Angular4DotNet.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        // GET: Courses
        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetCourseVms(), JsonRequestBehavior.AllowGet);
        }
    }
}