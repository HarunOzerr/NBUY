namespace Proje11_Collections_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            /*
            List<int> sayilar = new List<int>();
            sayilar.Add(12);
            sayilar.Add(120);
            sayilar.Add(69);
            sayilar.Add(28);
            sayilar.Add(316);

            List<string> isimler = new List<string>();
            isimler.Add("Ali");
            isimler.Add("Begüm");
            isimler.Add("Kemal");

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            */
            #endregion
            #region FirstSampe
            /*
            Product product1 = new Product() { Id = 1, Name = "Bilgisayar", Price = 28000 };
            Product product2 = new Product() { Id = 2, Name = "Telefon", Price = 18000 };
            Product product3 = new Product() { Id = 3, Name = "Masa Sandalye Takımı", Price = 8000 };
            */
            //List<Product> products = new List<Product>() { product1, product2, product3 };

            /*
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            */




            //Yeni bir liste yaratın. Adı da newProducts olsun. İçine tıpkı yukarıdaki gibi 3 yeni ürün bilgisi girin.
            //List<Product> newProducts = new List<Product>()
            //{
            //    new Product() { Id = 4, Name = "Televizyon", Price = 25000},
            //    new Product() { Id = 5, Name = "Kulaklık", Price = 3800},
            //    new Product() { Id = 6, Name = "MousePad", Price = 950}
            //};

            ////newProducts içindeki productları, products içine ekleyeceğiz.
            //products.AddRange(newProducts);

            ////products.ForEach(p => {
            ////    Console.WriteLine($"{p.Name} - {p.Price}");
            ////    Console.WriteLine();
            ////});

            //int elemanSayisi = products.Count; //sonunda parantez() olmayan count sadece get yapıyor

            //products.Insert(0, new Product() { Id=21, Name="Gözlük", Price = 1200 });

            //products.InsertRange(3, newProducts);


            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name} - {product.Price}");
            //}



            //List<Product> products = new List<Product>()
            //{
            //    new Product() { Id = 1, Name = "Telefon", Price = 19000},
            //    new Product() { Id = 2, Name = "Bilgisayar", Price = 39000},
            //    new Product() { Id = 3, Name = "Masa Sandalye", Price = 9000}
            //};

            //ProductModel productModel = new ProductModel()
            //{
            //    Id = 1,
            //    CategoryName = "First Category",
            //    Products = products
            //};
            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine($"\t{product.Name}");
            //}
            #endregion

            //İçinde 3 adet ProductModel tipinde veri barındıran bir List oluştur.
            //Her bir ProductModel içinde ise, Products özelliğine 3 adet Product koy.

            List<ProductModel> productModels = new List<ProductModel>()
            {
                new ProductModel()
                {
                    Id=1,
                    CategoryName="Bilgisayarlar",
                    Products= new List<Product>()
                    {
                        new Product() {Id=11, Name="Ürün11", Price=3500},
                        new Product() {Id=12, Name="Ürün12", Price=3500},
                        new Product() {Id=13, Name="Ürün13", Price=3500},
                    }
                },
                 new ProductModel()
                {
                    Id=1,
                    CategoryName="Mobilyalar",
                    Products= new List<Product>()
                    {
                        new Product() {Id=21, Name="Ürün21", Price=3500},
                        new Product() {Id=22, Name="Ürün22", Price=3500},
                        new Product() {Id=23, Name="Ürün23", Price=3500},
                    }
                },
                  new ProductModel()
                {
                    Id=1,
                    CategoryName="Eşyalar",
                    Products= new List<Product>()
                    {
                        new Product() {Id=31, Name="Ürün31", Price=3500},
                        new Product() {Id=32, Name="Ürün32", Price=3500},
                        new Product() {Id=33, Name="Ürün33", Price=3500},
                    }
                }

            };

            foreach (var productModel in productModels)
            {
                Console.WriteLine($"Product Model Id: {productModel.Id} - Category Name: {productModel.CategoryName}");
                foreach (var product in productModel.Products)
                {
                    Console.WriteLine($"\tProduct Id: {product.Id} - Product Name: {product.Name} - Product Price: {product.Price}");
                }
                Console.WriteLine("***********************************************");
            }


            Console.ReadLine();
        }
    }
}