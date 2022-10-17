namespace Proje09_IfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CTRL+K+D boşlukları düzeltir.
            /*
             * if(bool)
             * {
             *      bool true ise yapılacak işler.
             * }
             */

            /*
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>=0)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            */

            //Kullanıcıdan yaşını girmesini isteyelim.
            //18 yaşından küçüklere "GİRİŞ YASAK" mesajını yazdıralım

            /*
            Console.Write("Yaşınızı Girin: ");
            byte yas = Convert.ToByte(Console.ReadLine());
            if (yas < 18)
            {
               Console.WriteLine("GİRİŞ YASAK");
            }
            else if(yas > 18)
            {
               Console.WriteLine("Hoşgeldiniz.");
            }
            else
            {
               Console.WriteLine("Velinle birlikte gel.");
            }
            */

            /*
            //Girilen iki sayıdan büyük olanı yazdıralım.
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine($"Büyük olan sayı: {sayi1}");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine($"Büyük olan sayı: {sayi2}");
            }
            else
            {
                Console.WriteLine($"{sayi1} ve {sayi2} birbirine eşittir.");
            }
            */

            /*
            //Bu algoritma daha verimli ve kolaydır.
            //Girilen üç sayıdan büyük olanı yazdıralım.
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>=sayi2 && sayi1>=sayi3)
            {
                Console.WriteLine(sayi1);
            }
            else if (sayi2>=sayi1 && sayi2>=sayi3)
            {
                Console.WriteLine(sayi2);
            }
            else if (sayi3>sayi1 && sayi3>sayi2)
            {
                Console.WriteLine(sayi3);
            }
            */


            /*
            //Bu doğru olmayan bir algoritmadır.
            //Girilen üç sayıdan büyük olanı yazdıralım.
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>sayi2)
            {
                if (sayi1>sayi3)
                {
                    Console.WriteLine($"En Büyük Sayı: {sayi1}");
                }
            }
            if (sayi2>sayi1)
            {
                if(sayi2>sayi3)
                {
                    Console.WriteLine($"En Büyük Sayı: {sayi2}");
                }
            }
            if(sayi3>sayi1)
            {
                if (sayi3>sayi2)
                {
                    Console.WriteLine($"En Büyük Sayı: {sayi3}");
                }
            }
            */


            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayi1 > sayi2 ? "1. Sayı 2. Sayıdan büyüktür." :
                           sayi2 > sayi1 ? "2. Sayı 1. Sayıdan büyüktür." :
                                           "İki sayı birbirine eşittir";
            Console.WriteLine(sonuc);




            //int buyuksayi = sayi1 > sayi2 ? sayi1 : sayi2;
            //Console.WriteLine(buyuksayi);

            //-----------------------------------------
            //int buyuksayi = 0;
            //if (sayi1>sayi2)
            //{
            //    buyuksayi = sayi1;
            //}
            //else if (sayi2>sayi1)
            //{
            //    buyuksayi= sayi2;
            //}
            //Console.WriteLine(buyuksayi);
            //------------------------------------------



        }
    }
}