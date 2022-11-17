using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje05_MVC_EfCore_CodeFirst_Tekrar.Models;


namespace Proje05_MVC_EfCore_CodeFirst_Tekrar.Controllers
{
    public class BolumController : Controller
    {
        public IActionResult Index()
        {
            SchoolDbContext context = new SchoolDbContext();
            List<Bolum> bolums = context.Bolums.ToList();
            return View(bolums);
        }
    }
}