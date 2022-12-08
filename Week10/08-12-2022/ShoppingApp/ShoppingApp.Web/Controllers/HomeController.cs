using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productManager;

    public HomeController(IProductService productManager)
    {
        _productManager = productManager;
    }

    public async Task<IActionResult> Index()
    {
        //products değişkenine productları aktarmış olduk.
        List<Product> products = await _productManager.GetHomePageProductsAsync();
        List<ProductDto> productDtos = new List<ProductDto>();
        foreach (var product in products)
        {//Mapping olmadan bu şekilde dönüştürme yapmalıyız.
            productDtos.Add(new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImageUrl=product.ImageUrl,
                Url= product.Url,
            });
        }
        return View(productDtos); //Index'e products değişkenindeki verileri döndürdük.
    }

}
