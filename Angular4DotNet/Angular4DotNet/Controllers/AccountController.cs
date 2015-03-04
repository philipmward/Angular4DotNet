using Angular4DotNet.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVm student)
        {
            //_studentRegistrationService.Register(student);
            //aka do something
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}