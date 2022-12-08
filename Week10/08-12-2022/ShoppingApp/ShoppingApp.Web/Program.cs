using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//Services ile context, UnitOfWork ve Service'leri tanýmlýyoruz:
builder.Services.AddDbContext<ShopAppContext>(); //Contextimizi tanýmlýyoruz.
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //Eðer IUnitOfWork ten bahsedersem UnitOfWork istediðimi belirtiyorum.
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
    pattern: "kategoriler/{categoryurl?}", //Url kýsmýnda sadece kategorinin url'ini görmek için bu þekilde gösterdik yani siteismi.com/kategoriler/beyaz-esya olarak gözüküyor. Eðer default route gibi gösterseydik siteismi.com/Shop/ProductList/beyaz-esya þeklinde gözükecekti.
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
