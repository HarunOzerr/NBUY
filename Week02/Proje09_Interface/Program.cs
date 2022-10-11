namespace Proje09_Interface
{
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
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstract classtan, miras alan classta
             * Eğer base classta abstract bir methodlar varsa, mutlaka override edilmeli.
             * Eğer base classta abstract olmayan methodlar varsa, onlar aynen kullanılabilir.
             * Ancak bazen, miras alınan classtaki her methodun, içinin dolu hallerini yazmak zorunlu olsun isteriz.
             * Yani bir nevi hepsi abstract olsun isteriz. Bunu yapmak yerine, miras alınan classı, class değil
             * -interface şeklinde tanımlarız.
             */
            //IPersonel personel = new IPersonel(); //Hatalı kullanım!
            Yonetici yonetici1 = new Yonetici();
            Yonetici yonetici2 = new Yonetici("Alex De Souza", "Rio de Jenario", "5000", "Futbol");

        }
    }
}