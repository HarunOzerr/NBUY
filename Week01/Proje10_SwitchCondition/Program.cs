namespace Proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Klavyeden girilen sayının 5 olması halinde 2 katını , 10 olması halinde 3 katını
            //ya da 15 olmalı halinde ise 4 katını
            //                      --------------if ile çözümü-----------------
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            if (sayi == 5)
            {
                sonuc = sayi * 2;
            }
            else if (sayi == 10)
            {
                sonuc = sayi * 3;
            }
            else if (sayi == 15)
            {
                sonuc = sayi * 4;
            }
            if (sonuc==0)
            {
                Console.WriteLine("Tanımlanmamış değer.");
            }
            else
            {
                Console.WriteLine(sonuc);
            }
            */

            /*
            //                 ----------------SWİTCH CASE ile çözümü---------------------
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            switch (sayi)
            {
                case 5:
                    sonuc = sayi * 2;
                    break;
                case 10:
                    sonuc = sayi * 3;
                    break;
                case 15:
                    sonuc = sayi * 4;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            if (sonuc==0)
            {
                Console.WriteLine("Tanımlanmamış değer.");
            }
            else
            {
                Console.WriteLine(sonuc);
            }
            */



            //x-> <10 ise 2 ile çarp
            //x-> 11-20 arasındaysa 3 ile çarp
            //x-> 21-50 arasındaysa 4 ile çarp
            //x-> 51-100 arasındaysa 5 ile çarp
            //x-> >100 ise 10 ile çarp
            //                  -------------------Çözüm1: IF ile----------------------
            /*
            int x = 11;
            int katsayi = 0;
            if (x<=10)
            {
                katsayi = 2;
            }
            else if (x<=20)
            {
                katsayi = 3;
            }
            else if (x<=50)
            {
                katsayi = 4;

            }
            else if (x<=100)
            {
                katsayi = 5;

            }
            else
            {
                katsayi = 10;

            }
            int sonuc = x * katsayi;
            Console.WriteLine($"X= {x} , Sonuc: {x} x {katsayi}: {sonuc} ");
            */
            //                -----------------Çözüm2: SWITCH CASE ile-----------------------
            /*
            int x = 120;
            int katsayi = 0;
            switch (x)
            {
                case (>=0 and <=10):
                    {
                        katsayi = 2;
                    }
                    break;
                case (>= 21 and <= 50):
                    {
                        katsayi = 3;
                    }
                    break;
                case (>= 51 and <= 100):
                    {
                        katsayi = 4;
                    }
                    break;
                default:
                    katsayi = 6;
                    break;
            }
            int sonuc = x * katsayi;
            Console.WriteLine($"X: {x}, Sonuç: {x} x {katsayi} : {sonuc}");
            */



            //İçinde bulunduğunuz günün hafta içi mi yoksa hafta sonu mu olduğunu bulalım
            //                  --------------------Çözüm1: IF ile------------------------- 
            /*
            DateTime tarih = new DateTime(2022, 10, 8);
            DayOfWeek gun = tarih.DayOfWeek;
            if (gun==DayOfWeek.Saturday || gun==DayOfWeek.Sunday)
            {
                Console.WriteLine("Hafta sonundasın.");
            }
            else
            {
                Console.WriteLine("Hafta içindesin.");
            }
            */
            //              ---------------------Çözüm2: SWITCH CASE ile-----------------------------
            /*
            DateTime tarih = new DateTime(2022, 10, 8);
            DayOfWeek gun = tarih.DayOfWeek;
            switch (gun)
            {
                case DayOfWeek.Monday:            
                case DayOfWeek.Tuesday:            
                case DayOfWeek.Wednesday:        
                case DayOfWeek.Thursday:       
                case DayOfWeek.Friday:
                    Console.WriteLine("Hafta içindesin.");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Hafta sonundasın.");
                    break;
                default:
                    break;
            }
            */
        }
    }
}