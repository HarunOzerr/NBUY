using System.Reflection.Metadata;

namespace Proje07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(DateTime.Now); //günün tarihini saat ile birlikte yazdırır.
            //Console.WriteLine(DateTime.Today);//sadece günün tarihini yazdırır.

            /*
            DateTime dogumTarihi = new DateTime(2000, 4, 17);
            DateTime bugun=DateTime.Now;
            TimeSpan span=bugun.Subtract(dogumTarihi);
            Console.WriteLine($"Toplam {Math.Floor(span.TotalDays)} gündür yaşıyorsunuz.");
            */

            /*
            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun.ToLongDateString()); //5 Ekim 2022 Çarşamba
            Console.WriteLine(bugun.ToLongTimeString()); //15:35:30
            Console.WriteLine(bugun.ToShortDateString()); //5.10.2022
            Console.WriteLine(bugun.ToShortTimeString()); //13:35
            */

            /*
            //Bir sonraki yılın ilk gününün tarihini bulduralım.
            DateTime bugun = DateTime.Now;
            int yil=bugun.Year + 1;
            DateTime sonuc=new DateTime(yil, 1, 1);
            Console.WriteLine(sonuc.ToLongDateString());
            */

            /*
            //bir sonraki ayın ilk gününün tarihini bulduralım
            DateTime bugun = DateTime.Now;
            int ay = bugun.Month + 1;
            int yil = bugun.Year;
            DateTime sonuc = new DateTime(yil, ay, 1);
            Console.WriteLine(sonuc.ToLongDateString());
            */


            DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun + 1);  //çalışmaz hata verir.

            /*
             * Ö    D    E    V
             * Ertesi günün tarihini bulup ekrana yazdıran programı yazınız.
            */


        }
    }
}