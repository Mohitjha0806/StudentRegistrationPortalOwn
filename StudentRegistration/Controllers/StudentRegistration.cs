using Microsoft.AspNetCore.Mvc;

namespace StudentRegistration.Controllers
{
    public class StudentRegistration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult Create()
        {
            return View();
        }
         public IActionResult Edit()
        {
            return View();
        }

    }

}
