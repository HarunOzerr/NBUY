namespace Proje14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 45;
            int b = a * 2;

            Random rnd = new Random();
            Kisi kisi1= new Kisi();
            kisi1.Ad = "Harun";
            kisi1.Yas = 22;
            kisi1.Meslek = "Developer";

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Ahmet";
            kisi2.Yas = 30;
            kisi2.Meslek = "Developer";

            Kisi kisi3= new Kisi();
            kisi3.Ad = "Gonca";
            kisi3.Yas = 24;
            kisi3.Meslek = "Teacher";



            Araba araba1 = new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "Kırmızı";

            DateTime bugun=DateTime.Now;
            Random rnd2= new Random();

        }
        class Kisi
        {
            public string? Ad { get; set; }
            public int Yas { get; set; }
            public string? Meslek { get; set; }

        }
        class Araba
        {
            public string Marka { get; set; }
            public string Renk { get; set; }
            string VitesTuru { get; set; } 
            /*
             * Erişim Belirleyici: Bir property'nin dışarıdan yani içinde bulunduğu classın dışından erişim seviyesini belirleyen anahtar sözcüklere denir.
             * Eğer Herhangi bir erişim belirleyici kullanılmamışsa, default erişim belirleyici private olarak kabul edilir.
             * Erişim Belirleyiciler:
             * 1)public
             * 2)private
             * 3)internal
             * 4)protected
             */

        }
    }
}