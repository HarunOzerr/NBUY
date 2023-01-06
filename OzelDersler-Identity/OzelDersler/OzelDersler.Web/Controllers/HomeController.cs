using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OzelDersler.Business.Abstract;
using OzelDersler.Web.Models;

namespace OzelDersler.Web.Controllers;

public class HomeController : Controller
{
    private readonly IUserService _userManager;

    public HomeController(IUserService userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _userManager.GettAllAsync();
        List<UserDto> userDtos = new List<UserDto>();
        foreach (var user in users)
        {
            userDtos.Add(new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Experience = user.Experince,
                About = user.About,
                ImageUrl = user.ImageUrl,
                PricePerHour = user.PricePerHour 
            });
        }
        return View(userDtos);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
