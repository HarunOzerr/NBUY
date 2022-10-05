namespace Proje04_TipDonusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            byte a = 5;   //8 bitlik unsigned 0 dan 255 e kadar yazılabilir.
            short b = 10; //16bitlik
            sbyte c = 30; //8bitlik signed eksi(-) sayılar yazılabilir.
            int d = a + b + c; //Implicit Convert - Örtülü Dönüştürme yapıp int değerine dönüştürüp aktarıyor.
            Console.WriteLine($"Sonuç(d)= {d}");
            

            string metin = "NBUY";
            char karakter = 'k';
            object e = metin + karakter + d; //Implicit Convert - Örtülü Dönüştürme yapıp object'e(sınıfların kökeni) dönüştürüp aktarıyor
            Console.WriteLine($"Object= {e}");
            */

            //byte a = 155;
            //byte b = 101;
            //byte c = Convert.ToByte(a+b); //Explicit Convert - Bilinçli Dönüşüm
            //Console.WriteLine($"Sonuç: {c}");

            //byte d = (byte)(a + b); //Unboxing
            //Console.WriteLine($"Sonuç: {d}");


            //int a = 512;
            //byte b= (byte)a;
            //Console.WriteLine(b); //Çıkan sonuç alabileceği değerden fazla ise tur döndürür. 256=0 257=1 gibi.

            byte a = 155;
            byte b = 101;
            int c = a + b;
            Console.WriteLine(c);


            //Convert.ToDouble(c);
            //Convert.ToInt64(c);

        }
    }
}