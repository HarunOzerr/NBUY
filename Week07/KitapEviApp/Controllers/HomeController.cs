using System.Diagnostics;
using KitapEviApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KitapEviApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Kategori()
    {
        KitapEviContext context = new KitapEviContext();
        List<Kategori> kategoriler = context.Kategoriler.ToList();
        return View(kategoriler);
    }
    public IActionResult Yazar()
    {
        KitapEviContext context = new KitapEviContext();
        List<Yazar> yazarlar = context.Yazarlar.ToList();
        return View(yazarlar);
    }
    public IActionResult Kitap()
    {
        KitapEviContext context = new KitapEviContext();
        List<Kitap> kitaplar = context
        .Kitaplar
        .Include(k => k.Kategori)
        .Include(k => k.Yazar)
        .ToList();
        return View(kitaplar);
    }
}
