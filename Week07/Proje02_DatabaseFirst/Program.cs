using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;

var mt = new MultiTable();
// mt.MusteriSayisi();
// mt.SatisYapilanMusteriler();
// mt.SatisYapilmayanMusteriler();
mt.MusteriSatisListesi();



























// NorthWindContext context = new NorthWindContext();

// Bu örnek customer listesi alıyor
// List<Customer> customers = context.Customers.ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// }

//London'da yaşayan Customer'ların listesi:
// List<Customer> customers = context.Customers.Where(c => c.City == "London").ToList();
// foreach (var customer in customers)
// {
//     System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }


//London'da yaşayan Customer'ların sadece Company Name ve Contact Name'lerini getirelim.
// var customers = context
//     .Customers
//     .Select(c => new{c.CompanyName, c.ContactName, c.City})
//     .Where(c => c.City == "London")
//     .ToList();
// foreach (var customer in customers)
// {
//     System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// System.Console.WriteLine("Bitti");


//London'da yaşayan Customer'ların sadece Company Name ve Contact Name'lerini getirelim.
//Nesne kullanarak


// List<CustomerModel> customers = context
//     .Customers
//     .Select(c => new CustomerModel()
//     {
//         CompanyName = c.CompanyName,
//         ContactName = c.ContactName,
//         City = c.City
//     })
//     .Where(c => c.City == "London")
//     .ToList();
// foreach (var customer in customers)
// {
//     System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// System.Console.WriteLine("Bitti");


//Beverages kategorisindeki ürünlerin listesi
// var beveragesProducts = context
// .Products
// .Where(p => p.Category.CategoryName == "Beverages")
// .ToList();
// foreach (var p in beveragesProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }


// Suppliers tablosundaki Germany'de yaşayanları listeleyin.
// List<Supplier> germanySuppliers = context
// .Suppliers
// .Where(s => s.Country == "Germany")
// .ToList();
// foreach (var s in germanySuppliers)
// {
//     System.Console.WriteLine($"Company Name: {s.CompanyName} - Country: {s.Country}");
// }


//Nancy adındaki employee nin brezilya'ya satışlarını getir.
// var ordersOfNancy = context
// .Orders
// .Where(o => o.Employee.FirstName == "Nancy" && o.ShipCountry == "Brazil")
// .ToList();
// foreach (var o in ordersOfNancy)
// {
//     System.Console.WriteLine(o.OrderId);
// }
// System.Console.WriteLine($"Toplam Satış Sayısı: {ordersOfNancy.Count()}");

//Product'ları ID'ye göre büyükten küçüğe sıralı bir şekilde listeleyelim.
// var products = context
// .Products
// .OrderByDescending(p => p.ProductId)
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }


// En son satılan 5 ürünü listeyelim. 
// var products = context
// .Products
// .OrderByDescending(p => p.ProductId)
// .Take(5)
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }


// Fiyatı 10 ile 20 arası olan ürünlerin adını ve fiyatını getirip listeleyelim.
// var products = context
// .Products
// .Where(p => p.UnitPrice >= 10 && p.UnitPrice <=20)
// Eğer select komutunu Where komutundan önce verirsek Select komutunda belirttiğimiz alanlar where komutunda da bulunmak zorunda kalırdı.
// .Select(p => new{
//     p.ProductName,
//     p.UnitPrice
//     })
// .OrderBy(p => p.UnitPrice)
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName} / {p.UnitPrice}");
// }


// Beverages kategorisindeki ürünlerin ortalam fiyatını ekrana yazdıralım.
// var ortalama = context
// .Products
// .Where(p => p.Category.CategoryName == "Beverages")
// .Average(p => p.UnitPrice);
// System.Console.WriteLine($"Beverages Fiyat Ortalaması: {ortalama}");

// Beverages kategorisindeki ürün adedi
// var adet = context
// .Products
// .Where(p => p.Category.CategoryName == "Beverages")
// .Count();
// .Count(p => p.Category.CategoryName == "Beverages"); //Count içine saydırmak istediğimiz koşulu direkt olarak verebiliriz. Ekstra where kullanmamıza gerek kalmıyor.
// System.Console.WriteLine($"Beverages Ürün Adedi: {adet}");


// Beverages ve Condiments kategorilerinde toplam kaç adet ürün var ?
// var adet = context
// .Products
// .Count(p => p.Category.CategoryName == "Beverages" || p.Category.CategoryName == "Condiments");
// System.Console.WriteLine($"B&C Adet:{adet}");


// Adının içinde tofu geçen ürünleri listeyelim.
// var products = context
// .Products
// .Where(p => p.ProductName.Contains("tofu"))
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine(p.ProductName);
// }


// En ucuz ve en pahalı ürünler hangileridir?
// var minPrice = context.Products.Min(p => p.UnitPrice);
// var maxPrice = context.Products.Max(p => p.UnitPrice);

// var minProducts = context
// .Products
// .Where(p => p.UnitPrice == minPrice)
// .Select(p => new{
//     p.ProductName,
//     p.UnitPrice
//     })
// .FirstOrDefault();

// var maxProducts = context
// .Products
// .Where(p => p.UnitPrice == maxPrice)
// .Select(p => new{
//     p.ProductName,
//     p.UnitPrice
// }).FirstOrDefault();

// System.Console.WriteLine($"MinPrice: {minPrice} --> Product: {minProducts.ProductName} - {minProducts.UnitPrice}" );
// System.Console.WriteLine($"MaxPrice: {maxPrice} --> Product: {maxProducts}" );

// var minPrice = context.Products.Min(p => p.UnitPrice);
// var maxPrice = context.Products.Max(p => p.UnitPrice);

// var minProducts = context
// .Products
// .Where(p => p.UnitPrice == minPrice)
// .Select(p => new{p.ProductName})
// .ToList();
// foreach (var min in minProducts)
// {
//     System.Console.WriteLine($"En Düşük Fiyatlı Ürünler: {min.ProductName}");
// }

// var maxProducts = context
// .Products
// .Where(p => p.UnitPrice == maxPrice)
// .Select(p => new{p.ProductName})
// .ToList();
// foreach (var max in maxProducts)
// {
//     System.Console.WriteLine($"En Yüksek Fiyatlı Ürünler: {max.ProductName}");
// }










// class CustomerModel
// {
//     public string? CompanyName { get; set; }
//     public string? ContactName { get; set; }
//     public string? City { get; set; }
// }