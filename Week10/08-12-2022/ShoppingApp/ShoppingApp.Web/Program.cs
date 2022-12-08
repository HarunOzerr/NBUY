using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//Services ile context, UnitOfWork ve Service'leri tan�ml�yoruz:
builder.Services.AddDbContext<ShopAppContext>(); //Contextimizi tan�ml�yoruz.
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //E�er IUnitOfWork ten bahsedersem UnitOfWork istedi�imi belirtiyorum.
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "products",
    pattern: "kategoriler/{categoryurl?}", //Url k�sm�nda sadece kategorinin url'ini g�rmek i�in bu �ekilde g�sterdik yani siteismi.com/kategoriler/beyaz-esya olarak g�z�k�yor. E�er default route gibi g�sterseydik siteismi.com/Shop/ProductList/beyaz-esya �eklinde g�z�kecekti.
    defaults: new {controller="Shop", action="ProductList"}
    );

app.MapControllerRoute(
    name: "productdetails",
    pattern: "urunler/{producturl}",
    defaults: new { controller = "Shop", action = "ProductDetails" }
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "admin",
    areaName:"Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.Run();
