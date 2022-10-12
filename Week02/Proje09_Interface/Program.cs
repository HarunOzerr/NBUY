﻿namespace Proje09_Interface
{
    /* Interface'ler için belirtilmediğinde default erişim belirleyici public'tir.
     * Interface'ler protected, private, yada static olarak işaretlenemezler.
     * Interface'ler içinde çalışabilir kodlar OLAMAZ! Yani metotların sadece imzası bulunur.
     * Bir Interface, bir ya da daha çok interfaceden miras alabilir.
     * Bir interface classtan miras alamaz.
     * Eğer bir class, bir interface'ten miras alıyorsa, miras aldığı interface'teki tüm metotları
     * implemente etmek zorundadır.(Implemente: Miras alınan interfacede imzası bulunan tüm metotların içi dolu halleri)
     */
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public void Bilgi();//Interfaceler içindeki metotlarda sadece İMZA bulunur. Metotun gövdesi olmaz!
        //Metodun gövdesi, bu interfacei miras alan CLASS içinde doldurulur.
        //Interface new yapılamaz!
    }
    class Yonetici : IKisi, IPersonel
    {
        /// <summary>
        /// Bu metot, herhangi bir yönetici bilgisi girmeden, yönetici oluşturur.
        /// </summary>
        public Yonetici()
        {
            /*Kimi zaman AdSoyad, Adres, Maas ve Departman bilgisini vermeden de yönetici oluşturmak
            *istediğimiz zaman bu constructor çalışır
            */
}
/// <summary>
/// Bu metot, AdSoyad, Adres, Maas, Departman bilgileri girilerek yönetici oluşturur.
/// </summary>
/// <param name="adSoyad">Buraya Ad Soyadı girin.</param>
/// <param name="adres">Buraya adresi girin.</param>
/// <param name="maas">Buraya maaşı girin, ama yanlışlıkla string tanımladım.</param>
/// <param name="departman">Buraya departmanı girin.</param>
    public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }

        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"Ad Soyad: {AdSoyad} Departman: {Departman}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstract classtan, miras alan classta
             * Eğer base classta abstract bir methodlar varsa, mutlaka override edilmeli.
             * Eğer base classta abstract olmayan methodlar varsa, onlar aynen kullanılabilir.
             * Ancak bazen, miras alınan classtaki her methodun, içinin dolu hallerini yazmak zorunlu olsun isteriz.
             * Yani bir nevi hepsi abstract olsun isteriz. Bunu yapmak yerine, miras alınan classı, class değil
             * interface şeklinde tanımlarız.
             */
            //IPersonel personel = new IPersonel(); //Hatalı kullanım!
            //Yonetici yonetici1 = new Yonetici();
            //Yonetici yonetici2 = new Yonetici("Alex De Souza", "Rio de Jenario", "5000", "Futbol");

            Product product1 = new Product()
            {
                Id = 1,
                Name = "Iphone 11 Pro Max",
                Price = 15750,
                Properties = "3 Kameralı",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now
            };
            Console.WriteLine($"Product Name: {product1.Name} (Büyük Harf: {product1.NameToUpper(product1.Name)}) Properties: {product1.Properties})");

            Category category1 = new Category()
            {
                Id = 1,
                Name = "Telefon",
                CreatedDate = DateTime.Now,
                Description = "Bu kategori telefonlar içindir."
            };
            Console.WriteLine($"Category Name: {category1.Name} Büyük Harf:({category1.NameToUpper(category1.Description)}");
            Console.ReadLine();
        }
    }
}