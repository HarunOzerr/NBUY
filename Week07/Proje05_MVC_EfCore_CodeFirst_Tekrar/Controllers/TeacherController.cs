using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Proje05_MVC_EfCore_CodeFirst_Tekrar.Models;

namespace Proje05_MVC_EfCore_CodeFirst_Tekrar.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            SchoolDbContext context = new SchoolDbContext();
            List<Teacher> teachers = context
            .Teachers
            .Include(t => t.Bolum)
            .ToList();
            return View(teachers);
        }

    }
}