using System.Reflection.Metadata;

namespace Proje03_DegiskenOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi1 = 120;
            int sayi2 = 110;
            Console.WriteLine(sayi1 + "\n" + sayi2); //alt satıra geçirmek için /n kullanılır
            Console.WriteLine($"SAYI1: {sayi1}\nSAYI2: {sayi2}");// $ işareti {} içinde birleştirme için kulanılır.
            Console.WriteLine(sayi1 + sayi2); // int değişkenlerde artı(+) işareti toplama yapar.
            Console.WriteLine(sayi1.ToString() + sayi2);// ToString() int olan değişkeni string yapıyor.


            string sayi3 = "120";
            int sayi4 = 110;
            Console.WriteLine(sayi3+sayi4); // string değişken varsa (+) işareti yan yana yazdırır.
            Console.WriteLine(Convert.ToInt32(sayi3)+sayi4); //Convert.ToIn32(değiskenadi) int yapmaya yarar.
            */

            // double ondalık sayılar
            // float hassas ondalık sayılar
            // decimal hassas parasal sayılar
            decimal sayi1 = 0.1m;
            decimal sayi2 = 0.7m;
            decimal sayi3 = 0.8m;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);

            Console.WriteLine(sayi1+sayi2);
            Console.WriteLine((sayi1+sayi2) == sayi3);


        }
    }
}