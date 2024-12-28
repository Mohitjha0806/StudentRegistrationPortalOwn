using StudentRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace StudentRegistration.Controllers
{

    public class StudentRegistration : Controller
    {
        private readonly StudentEducationPortalDbContext context;



        public StudentRegistration(StudentEducationPortalDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(TblStudentRegTable tblStudentRegTable)
        {
            if (ModelState.IsValid)
            {
                context.Add(tblStudentRegTable);
                context.SaveChanges();

            }
            return View();

        }

    }
}
