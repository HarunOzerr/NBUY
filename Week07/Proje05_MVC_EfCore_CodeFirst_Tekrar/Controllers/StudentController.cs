using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proje05_MVC_EfCore_CodeFirst_Tekrar.Models;

namespace Proje05_MVC_EfCore_CodeFirst_Tekrar.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            SchoolDbContext context  = new SchoolDbContext();
            List<Student> students = context.Students.ToList();
            return View(students);
        }   
    }
}