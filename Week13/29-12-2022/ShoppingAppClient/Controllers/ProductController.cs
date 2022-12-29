using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;
using System.Text;

namespace ShoppingAppClient.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var urunler = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/products/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    urunler = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse);
                }
            }
            return View(urunler);
        }

        public async Task<IActionResult> Create()
        {
            var kategoriler = new List<CategoryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/categories/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    kategoriler = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            var productViewModel = new ProductViewModel
            {
                Categories = kategoriler
            };
            return View(productViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var httpclient = new HttpClient())
                {
                    var serializeProductViewModel = JsonConvert.SerializeObject(productViewModel);
                    StringContent stringContent = new StringContent(serializeProductViewModel, Encoding.UTF8, "application/json"); //string contentin UTF8 yapısında ve json formatında olduğunu belirtmezsek düz StringContent oluşturuyor ve Unsupported media hatası veriyor.
                    await httpclient.PostAsync("http://localhost:5200/api/products", stringContent);
                }
            }
            return RedirectToAction("Index");

        }
    }
}
