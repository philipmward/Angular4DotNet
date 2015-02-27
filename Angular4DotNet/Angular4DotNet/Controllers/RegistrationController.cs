using Angular4DotNet.Models.Courses;
using Angular4DotNet.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        // GET: Hello
        public ActionResult Index()
        {
            return View(_registrationVmBuilder.BuildRegistrationVm());
        }
    }
}