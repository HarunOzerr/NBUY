namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}. Hello, World!");
            }
            */

            /*
            int toplam = 0;
            for (int i = 1; i < 10; i++)
            {
                //toplam = toplam + i;
                toplam += i;
            }
            Console.WriteLine($"Toplam: {toplam}");
            */

            /*
            //1 ile 10 arasındaki çift sayıların toplamını buldurun.
            int toplam = 0;
            for (int i = 0; i <= 10; i++) //veya for (int i = 0; i <= 10; i=i+2) yapılabilir.
            {
                if (i % 2==0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
            */

            //1-10 arasındaki çift sayıların toplamını ayrı tek sayıların toplamını ayrı gösteren kodu yazınız.
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 1; i <= 10; i++) //veya for (int i = 0; i <= 10; i=i+2) yapılabilir.
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
                
            }
            Console.WriteLine($"Tek Sayıların Toplamı: {tekToplam}\nÇift Sayıların Toplamı: {ciftToplam}");
        }
    }
}