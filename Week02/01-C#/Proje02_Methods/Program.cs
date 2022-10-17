using System.Diagnostics.Tracing;
using System.Security.Cryptography;

namespace Proje02_Methods
{
    public class Program
    {
        //static void Topla(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Toplam: {toplam}");
        //}
        //static void Cikar(int sayi1, int sayi2)
        //{
        //    int fark = sayi1 - sayi2;
        //    Console.WriteLine($"Fark: {fark}");
        //}
        static int SiraNoBul(string metin, char karakter)
        {
            int sonuc=metin.IndexOf(karakter);
            return sonuc;
        }
        static bool VarMi(string metin, char karakter)
        {
            bool sonuc = metin.Contains(karakter);
            return sonuc;
        }
        //public static int Topla(int sayi1, int sayi2)
        //{
        //    int topla = sayi1 + sayi2;
        //    return topla;
        //}
        static int Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }

        static void Main(string[] args) //METHOD
        {
            /*
            Console.Write("Birinci Sayı: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int s2 = int.Parse(Console.ReadLine());

            int toplam = Topla(s1, s2);
            int fark = Cikar(s1, s2);

            Console.WriteLine($"Toplam: {toplam}, Fark: {fark}");
            Console.WriteLine($"{toplam - fark}");
            */

            //Kendisine verilen metnin içinde aradığımız karakterin kaçıncı sırada olduğunu bulan metodu hazırlayınız.

            //Kendisine verilen metnin içinde aradığımız karakterin olup olmadığını bize söyleyen bir metodu hazırlayınız.


            //char karakter=char.Parse(Console.ReadLine().ToLower());
            //Console.WriteLine($"{SiraNoBul}");

            #region MethodOverloads
            MethodOverload methodOverload = new MethodOverload();
            //Console.WriteLine(methodOverload.Topla(15,25));
            //Console.WriteLine(methodOverload.İslem(50,10,5)
            int[] sayilar = { 55, 66, 75, 84, 93, 11, 22 };
            Console.WriteLine(methodOverload.Topla(sayilar));


            #endregion

        }
    }
}