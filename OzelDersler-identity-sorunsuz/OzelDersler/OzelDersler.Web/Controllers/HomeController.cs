using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OzelDersler.Business.Abstract;
using OzelDersler.Entity.Concrete;
using OzelDersler.Web.Models;

namespace OzelDersler.Web.Controllers;

public class HomeController : Controller
{
    private readonly ITeacherService _teacherService;

    public HomeController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    public async Task<IActionResult> Index()
    {
        List<Teacher> teachers = await _teacherService.GetHomePageTeachersAsync();
        List<TeacherDto> teacherDtos = new List<TeacherDto>();
        foreach (var teacher in teachers)
        {
            teacherDtos.Add(new TeacherDto
            {
                Id = teacher.Id,
                FirstName= teacher.FirstName,
                LastName = teacher.LastName,
                Age = teacher.Age,
                ImageUrl = teacher.ImageUrl,
                City = teacher.City,
                About = teacher.About,
                PricePerHour = teacher.PricePerHour,
                Experience = teacher.Experience
            }
            );
        }
        return View(teacherDtos);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
