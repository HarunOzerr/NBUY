using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Proje12_OOP_Work_01
{
    interface IKisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public class Bolum : IKisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; } 
    }
    public class Ogrenci : IKisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrNo { get; set; }
        public int Yas { get; set; }
    }
    internal class Program
    {
        static string stringGir(string istenilenMetin)
        {
            Console.Write(istenilenMetin);
            istenilenMetin = (Console.ReadLine());
            return istenilenMetin;
        }
        static int intGir(string istenilenMetin)
        {
            Console.Write(istenilenMetin);
            istenilenMetin=Console.ReadLine();
            return int.Parse(istenilenMetin);
        }
        static void Main(string[] args)
        {
            List<Bolum> bolums = new List<Bolum>();
            for (int i = 0; i < 2; i++)
            {
                new Bolum()
                {
                    Id = intGir("Id Gir: "),
                    Ad = stringGir("Ad Gir: "),
                    Aciklama = stringGir("Aciklama Gir: "),
                    Ogrenciler = new List<Ogrenci>()
                    {
                        new Ogrenci() {Id=intGir("Id: "), OgrNo=intGir("Öğrenci No:"), Ad=stringGir("Ad Gir: "), Soyad=stringGir("Soyad Gir: "), Yas=intGir("Yaş Gir: ")}
                    }
                };
            }
            foreach (var bolumler in bolums)
            {
                Console.WriteLine($"{bolumler.Id} , {bolumler.Ad} , {bolumler.Aciklama}");
                foreach (var ogrenci in bolumler.Ogrenciler)
                {
                    Console.WriteLine($"Öğrenci Id: {ogrenci.Id} - Öğrenci No: {ogrenci.OgrNo} - Öğrenci Ad: {ogrenci.Ad} - Öğrenci Soyad: {ogrenci.Soyad} - Öğrenci Yaş: {ogrenci.Yas}");
                }
            }
            Console.ReadKey();

        }
    }
}