using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje05_MVC_EfCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_EfCore_CodeFirst.Controllers
{
    // Her controller oluştururken vereceğimiz ismin sonuna Controller eklemek zorundayız.
    // ProductController
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            MyDbContext context =  new MyDbContext();
            List<Product> products = context.
            Products
            .Include(p => p.Category) // Category tablosunun içeriğini getirip dahil etmeye yarar. Yani inner join yapar.
            .ToList();
            return View(products);
        }
    }
}