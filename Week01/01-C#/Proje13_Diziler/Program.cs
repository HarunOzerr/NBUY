using System.Globalization;

namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string ad;
            ad = "Engin";

            string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";

            */
            /*
            string[] adlar = new string[7]; //İçinde 7 adet string bilgi tutabilecek bir dizi.
            adlar[0] = "Fatih Candan";
            adlar[1] = "Cemal Gündem";
            adlar[2] = "Selin Dilci";
            adlar[3] = "Kemal Kurt";
            adlar[4] = "Begüm yancı";
            adlar[5] = "Selma Halıcı";
            adlar[6] = "Emre Mor";
            //Console.WriteLine(adlar[0]);

            for (int i = 0; i < adlar.Length; i++)
            {
            //    Console.WriteLine(adlar[i]);
            //}
            //*/

            //int[] yaslar=new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };

            ////int toplam = 0;
            ////for (int i = 0; i < rakamlar.Length; i++)
            ////{
            ////    toplam += rakamlar[i];
            ////}
            ////Console.WriteLine(toplam);

            ////string okul = "Wissen Akademie";
            ////Console.WriteLine(okul[0]);

            ////ÇALIŞMA: Klavyeden kullanıcının adını soyadını girmesini isteyiniz.
            ////Girilen ad soyadı aşağıya doğru yazdrınız.

            ////Console.Write("Adınız Soyadınız: ");
            ////string ad = Console.ReadLine().ToUpper();
            ////for (int i = 0; i < ad.Length; i++)
            ////{
            ////    Console.WriteLine(ad[i]);
            ////}

            ///*
            //Console.Write("Bir metin giriniz.");
            //string girilenMetin=Console.ReadLine().ToLower();
            //Console.Write("Hangi karakterin sırasını bulmamı istersiniz?");
            //string karakter = Console.ReadLine().ToLower();
            //int siraNo = girilenMetin.IndexOf(karakter)+1;
            //Console.Clear(); //Sonucu göstermeden öncekileri silmeye yarar
            //Console.WriteLine($"Girilen Metin: {girilenMetin}\nAradığınız Karakter: {karakter}\nAradığınız karakterin sırası: {siraNo}");
            //*/
            //Console.WriteLine("Dizinin Orjinal Hali");
            //Console.WriteLine("********************");
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.Eleman: {rakamlar[i]}");
            //}

            //Console.WriteLine();

            ///*
            ////Kendimiz en büyük sayıyı buluyoruz.
            //int enBuyukSayi = rakamlar[0];
            //int enKucukSayi = rakamlar[0];
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i] > enBuyukSayi)
            //    {
            //        enBuyukSayi = rakamlar[i];
            //    }
            //    if (rakamlar[i] < enKucukSayi)
            //    {
            //        enKucukSayi = rakamlar[i];
            //    }
            //}
            //*/
            ////Console.WriteLine($"En Büyük Sayı: {enBuyukSayi}\nEn Küçük Sayı: {enKucukSayi}");
            ////-------------İSTEĞE BAĞLI ÇALIŞMA ÖDEVİ: Bu diziyi küçükten büyüğe doğru sıralayınız.-------------------

            ////Console.WriteLine($"En Küçük:\t{rakamlar.Min()}"); //\t TAB basmış kadar boşluk bırakır.
            ////Console.WriteLine($"En Büyük:\t{rakamlar.Max()}");


            ////Console.WriteLine("Dizinin ters çevrilmiş hali");
            ////Console.WriteLine("***************************");
            ////Array.Reverse(rakamlar); //Diziye terse çevirir.
            ////for (int i = 0; i < rakamlar.Length; i++)
            ////{
            ////    Console.WriteLine($"{i + 1}.Eleman: {rakamlar[i]}");
            ////}
            ////Console.WriteLine();


            //Console.WriteLine("Dizinin Küçükten Büyüğe sıralanmış hali");
            //Console.WriteLine("***************************************");
            //Array.Sort(rakamlar); //Sort, default olarak küçükten büyüğe sıralar.
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman: {rakamlar[i]}");
            //}
            //Console.WriteLine();


            //Console.WriteLine("Dizinin Büyükten Küçüğe sıralanmış hali");
            //Console.WriteLine("***************************************");
            //Array.Sort(rakamlar); //Sort, default olarak küçükten büyüğe sıralar.
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman: {rakamlar[i]}");
            //}
            //Console.WriteLine();



            //                   ---------------------------ÖRNEKLER--------------------------
            //Örnek1: sayilar dizisinin elemanlarının ortalamasını bulup ekrana yazdıralım
            //int[] sayilar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayilar.Sum();
            //Console.WriteLine($"Toplam: {toplam}");
            //Örnek2:sayilar dizisindeki çift sayıları ekrana yazdıralım.
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] %2 ==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            //ÖRNEK3:sayilar dizisindeki sayıları yanlarında pozitif, negatif ya da işaretsiz olma bilgileriyle yazdıralım.
            //string tip = "";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    tip = sayilar[i] > 0 ? "Pozitif" :
            //          sayilar[i] < 0 ? "Negatif" :
            //                           "İşaretsiz";
            //    Console.WriteLine($"{i + 1}.Sayı: {sayilar[i]} - Tipi: {tip} ");

            //}
            //ÖRNEK4:Kullanıcının gireceği bir metnin içindeki sesli harf sayısını ekrana yazdıran program.
            /*
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int sesliHarfAdedi = 0;
            Console.Write("Bir metin giriniz.");
            string girilenMetin = Console.ReadLine().ToLower();
            for (int i = 0; i < girilenMetin.Length; i++)
            {
                if (sesliHarfler.Contains(girilenMetin[i])) //Contains=içerisinde bulunuyor mu true or false kontrol ediyor.
                {
                    sesliHarfAdedi++;
                }
            }
            Console.WriteLine(sesliHarfAdedi);
            */

            //ÖRNEK5: Klavyeden girilen bir CÜMLE'deki yine klavyeden girilecek bir KELİMENİN kaç kez geçtiğini bulduralım.
            //string ornekMetin = "Harun Özer İstanbul";
            //string[] sozcukDizisi = ornekMetin.Split(" ");
            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}
            /*
            //ÇÖZÜM
            int sozcukAdedi = 0;
            Console.Write("Cümleyi giriniz:");
            string girilenCumle=Console.ReadLine();
            Console.Write("Adedini bulmak istediğiniz sözcüğü girin.");
            string sayilacakSozcuk=Console.ReadLine();
            string[] girilenCumleninDiziHali = girilenCumle.Split(" ");
            for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            {
                if (sayilacakSozcuk.ToLower() == girilenCumleninDiziHali[i].ToLower())
                {
                    sozcukAdedi++;
                }
                Console.WriteLine($"'{girilenCumle}' içinde '{sayilacakSozcuk} sözcüğü {sozcukAdedi} kez geçmektedir.");
            }
            */

            //              -----------------------------ARAŞTIRMA ÖDEVİ-------------------------------------
            // Çok boyutlu dizileri araştırın.
            //              -----------------------------PROJE ÖDEVİ-----------------------------------------
            /*
             * İçinde Türkçe karakterler hariç tüm küçük harfler,
             * 0-9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-) karakteri bulunabilecek.
             * Toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız.
             */


            char[] karakterler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                   'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z', 'x', 'w'
                                 , '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',', '+', '-'};
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int rastgele = random.Next(0, karakterler.Length);
                Console.Write(karakterler[rastgele]);
            }

        }
    }
}