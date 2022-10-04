namespace Proje05_MetinselMetotlar;
class Program
{
    static void Main(string[] args)
    {
        //Bu projede metinsel işlemlere dair bazı metotlar öğreneceğiz.
        /*
        string metin = "Wissen Akademie";
        int uzunluk = metin.Length;  //metnin uzunluğunu gösterme
        Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");
        */

        /*
        string metin = "WİSSEN";
        string kucukMetin= metin.ToLower(); // Küçük harfe dönüştürme
        Console.WriteLine(kucukMetin);
        string buyukMetin=kucukMetin.ToUpper(); //Büyük harfe dönüştürme
        Console.WriteLine(buyukMetin);
        */

        /*
        string m1 = "Wissen";
        string m2 = "Wissen Akademie";
        int sonuc=String.Compare(m1, m2); //string değerleri karşılaştırma
        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine(sonuc);
        */

        /*
        Console.Write("1. Metni Giriniz: ");
        string m1 = Console.ReadLine();
        Console.Write("2. Metni Giriniz: ");
        string m2 = Console.ReadLine();
        int sonuc = String.Compare(m1, m2);
        if (sonuc==0)   //Compare büyük küçük harf duyarlıdır.
        {
            Console.WriteLine("Girilen iki metin birbirine eşittir.");
        }
        else
        {
            Console.WriteLine("Girilen iki metin birbirinden farklıdır.");
        }
        */

        /*
        string m1 = "İşkur";
        string m2 = "Eğitimleri";
        string m3 = "Wissen";
        Console.WriteLine(m1+ m2+ m3);
        string sonuc=string.Concat(m1, m2, m3);  //Metinleri birleştirmeye yarar.
        Console.WriteLine(sonuc);
        */

        /*
        string ad = "Harun";
        int yas = 22;
        string okul = "BAU";

        Console.WriteLine("Benim adım " + ad + ". " + yas + " yaşındayım. Okuduğum okulun adı " + okul);

        string sonuc = string.Concat("Benim adım ", ad, ". " , yas, " Yaşındayım. Okuduğum okulun adı ", okul);
        Console.WriteLine(sonuc);

        Console.WriteLine($"Benim adım {ad}. {yas} yaşındayım. Okuduğum okulun adı {okul}");
        */

        /*
        string metin = "Merhaba. Bu hafta eğitime başladık.";
        bool sonuc= metin.Contains("hafta"); //metin değişkeninin içinde (hafta) olup olmadığını kontrol eder.
        Console.WriteLine(sonuc);
        */

        //string adres = "İstanbul Şehit Ali mh. Can sk. No:6 Kadıköy/Ankara";
        //Bitişi (İstanbul) mu ?
        //bool sonuc = adres.EndsWith("İstanbul"); 
        //Başlangıcı (İstanbul) mu?
        //bool sonuc2=adres.StartsWith("İstanbul");
        //Console.WriteLine(sonuc);

        //Adres içindeki c harfi kaçıncı sıradadır?
        /*
        string aranacakIfade = "c";

        int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
        Console.WriteLine($"C harfi {adres} içinde , {siraNo}.sıradadır.");
        */

        /*
        string aranacakIfade = "ŞeHiT Alİ";

        int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
        Console.WriteLine($"{aranacakIfade} ifadesi {adres} içinde, {siraNo}.sıradadır.");
        */
        //

    }
}
