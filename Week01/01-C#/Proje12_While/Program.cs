namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        /*
        int sayac=1;
        while (sayac<=5)
        {
            Console.WriteLine("Hello, World!");
            sayac++;
        }
        
        */

        /*
        int toplam=0;
        string girilenDeger="";
        int sayac=1;
        while (girilenDeger!="exit")
        {
            Console.Write($"{sayac}.Sayıyı Giriniz(Çıkış için exit): ");
            girilenDeger=Console.ReadLine();
            //if (girilenDeger!="exit") toplam+=Convert.ToInt32(girilenDeger);
            try
            {
            toplam+=Convert.ToInt32(girilenDeger);
            }
            catch (System.Exception)
            {
                break;
            }
            sayac++;
        }
        System.Console.WriteLine($"Toplam: {toplam}");
        */

        //SORU: Klavyeden exit yazılana kadar isim girilmesini isteyen uygulama
        //                                               ------------------ÇÖZÜM1--------------------
        /*
        string isim="";
        while (isim!="exit")
        {
            System.Console.Write("İsim giriniz: ");
            isim=Console.ReadLine();
        }
        System.Console.WriteLine("Program sona erdi.");
        
                                                       -------------------ÇÖZÜM2-------------------------

        string isim="";
        do
        {
            System.Console.WriteLine("İsim giriniz: ");
            isim=Console.ReadLine();
        } while (isim!="exit");
        System.Console.WriteLine("Program sona erdi.");
        */

        //Klavyeden exit yazılana kadar sayı almaya devam eden ve exit yazılınca bu sayıların toplamını ekrana yazan program.
        //Do-While ile
        /*
        string girilenDeger="0";
        int sayac=1;
        int toplam=0;
        do
        {
            System.Console.Write($"{sayac}. Sayıyı Giriniz: ");
            girilenDeger=Console.ReadLine();
            if(girilenDeger!="exit")
            {
            toplam += Convert.ToInt32(girilenDeger);
            sayac++;
            }
        } while (girilenDeger!="exit");
        System.Console.WriteLine($"{toplam}");
        */

        /*
        Random rastgele = new Random();
        int rastgeleSayi= rastgele.Next();
        System.Console.WriteLine(rastgeleSayi);
        int rastgeleSayi2=rastgele.Next(100); //0-100 arasında rastgele sayı üretir. 0 dahil ama 100 hariçtir.
        System.Console.WriteLine(rastgeleSayi2);
        int rastgeleSayi3=rastgele.Next(1000,2000);// 1000-2000 arasında rastgele sayı üretir.1000 dahil ama 2000 hariçtir. 
        System.Console.WriteLine(rastgeleSayi3);
        */

        
        //OYUN: Uygulamanın rastgele üreteceği bir sayıyı kullanıcının tahmin etmesini isteyeceğiz.
        //Rastgele üretilecek olan sayı 1-101 arasında olsun
        //Kullanıcı rastgele sayıdan küçük ya da büyük bir sayı girdiğinde kullanıcıya uygun bir şekilde mesaj verilsin.
        //Doğru sayıyı tahmin edene kadar uygulama çalışsın.
        /*
        Random rnd = new Random();
        int uretilenSayi = rnd.Next(1, 101);
        System.Console.WriteLine($"Hile: {uretilenSayi}");
        System.Console.WriteLine("*************");
        int tahminEdilenSayi;
        int hak = 1;  //Kullacının o sırada kaçıncı hakkını kullandığı bilgisi.
        int hakSiniri = 5;//Kullanıcının toplam kaç hakkı olduğu bilgisi.
        
        do
        {
            System.Console.Write($"{hak}. Tahmininizi Girin:(1-100): ");
            tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            if (hak==hakSiniri && uretilenSayi!=tahminEdilenSayi)
            {
                System.Console.WriteLine("Kaybettiniz.");
                break;
            }
            
            if (tahminEdilenSayi > uretilenSayi)
            {
                System.Console.WriteLine("Büyük bir değer girdiniz. Küçük değer girerek deneyin.");
            }
            else if (tahminEdilenSayi < uretilenSayi)
            {
                System.Console.WriteLine("Küçük bir değer girdiniz. Büyük değer girerek deneyin");
            }
            else
            {
                System.Console.WriteLine("Tebrikler.");
            }
                hak++;
            
        } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);
        */

        Random rnd = new Random();
        int uretilenSayi = rnd.Next(1, 101);
        System.Console.WriteLine($"Hile: {uretilenSayi}");
        System.Console.WriteLine("*************");
        int tahminEdilenSayi;
        int hak = 1;  //Kullacının o sırada kaçıncı hakkını kullandığı bilgisi.
        int hakSiniri = 5;//Kullanıcının toplam kaç hakkı olduğu bilgisi.
        string mesaj="";
        do
        {
            System.Console.WriteLine($"{hak}. Tahmininizi Giriniz(1-100): ");
            tahminEdilenSayi=Convert.ToInt32(Console.ReadLine());
            if (tahminEdilenSayi>uretilenSayi) 
            {
                mesaj="Büyük Girdin.";
            }
            else if (tahminEdilenSayi<uretilenSayi)
            {
                mesaj="Küçük Girdin.";
            }
            if (tahminEdilenSayi!=uretilenSayi)
            {
                hak++;
                if (hak < hakSiniri) System.Console.WriteLine(mesaj);
            }

        } while (tahminEdilenSayi!=uretilenSayi && hak<=hakSiniri);

        mesaj= tahminEdilenSayi == uretilenSayi ? "Kazandınız." : "Kaybettiniz.";
        /*
        if (tahminEdilenSayi==uretilenSayi)
        {
            System.Console.WriteLine("Kazandınız.");
        }
        else
        {
            System.Console.WriteLine("Kaybettiniz.");
        }
        */
        //Eğer program bu satıra gelmiş ise ya doğru tahminde bulunulmuştur ya da hak sona ermiştir.
        //KESİNLİKLE BU PROGRAM ÇOK ÇEŞİTLİ/FARKLI ALGORİTMALARLA ÇÖZÜLEBİLİR.
        
    }
}
