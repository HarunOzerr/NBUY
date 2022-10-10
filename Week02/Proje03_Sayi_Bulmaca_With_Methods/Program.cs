namespace Proje03_Sayi_Bulmaca_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sayi bulmaca oyununu, yeni öğrendiğiniz Methods konusu bağlamında yeniden hazırlayınız.
            string tercih;
            do
            {
                Console.Clear();
                Oyun.Oyna();
                do
                {
                    //Console.Clear();
                    Console.Write("Yeniden oynamak ster misiniz [E/H]: ");
                    tercih = Console.ReadLine().ToUpper();
                } while (tercih != "H" && tercih != "E");
            } while (tercih!="H");
            Console.ReadKey();

        }
    }
}