﻿namespace Proje08_HataKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                //Buraya normalde çalışmasını istediğimiz kodları yazıyoruz.
                //Try bloğunda herhangi bir HATA var mı yok mu kontrol ediliyor.
                //Eğer bir hata oluşursa, CATCH bloğuna yönlendiriliyor.
                Console.Write("1. Sayıyı Giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı Giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
			catch (DivideByZeroException ex)
			{
                Console.WriteLine("0'a bölünme hatası.");
                //Console.WriteLine(ex.Message);
			}
            catch(OverflowException ex)
            {
                Console.WriteLine("Haddinden fazla büyük bir sayı girdiniz.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu.");
            }
            finally
            {
                //try yada catch bloklarından hangisi çalışırsa çalışsın her halükarda çalışmasını istediğimiz kodları buraya yazarız.
                Console.WriteLine("Program sona ermiştir.");
            }
        }
    }
}