using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//Services ile context, UnitOfWork ve Service'leri tanımlıyoruz:
builder.Services.AddDbContext<ShopAppContext>(); //Contextimizi tanımlıyoruz.
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //Eğer IUnitOfWork ten bahsedersem UnitOfWork istediğimi belirtiyorum.
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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
