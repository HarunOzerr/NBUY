using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void Yazdir(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("Defalt Sıra");
            Yazdir(sayilar);
            Console.WriteLine("************");
            Console.WriteLine("Küçükten Büyüğe Sıralı");
            sayilar.Sort();
            Yazdir(sayilar);
            Console.WriteLine("************");
            Console.WriteLine("Büyükten Küçüğe Sıralı");
            sayilar.Reverse();
            Yazdir(sayilar);

            /* ------------------------------FOR İLE-------------------------------
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            */
            /*---------------------------FOREACH İLE-------------------------
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            */










            //ArrayList myList = new ArrayList();

            //myList.Add(120);
            //myList.Add("120");
            //myList.Add("Zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(true);


            //myList.Insert(0, "Yeni Eleman");

            //ArrayList addedList = new ArrayList()
            //{
            //    "Ayşen Umay",
            //    "Fercan Sercan",
            //    "Kazım Kolkanat"
            //};
            //myList.InsertRange(4,addedList); //Belirtilen yerden itibaren ekler.
            //myList.AddRange(addedList); //Listenin sonuna ekler.

            //myList.Remove("Zeynep");//Silmek istediğiniz nesnenin kendisi yazılır.
            ////myList.RemoveAt(0);//Listenin içerisinde istediğiniz indexteki silinir.
            ////myList.RemoveRange(0, 3);//Belirtilen aralıktan siler.


            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}
            //if (myList.Contains("Zeynep") == true )
            //{
            //    Console.WriteLine("Evet, Zeynep listede mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Acil Zeynep'e haber ver! Listede yok.");
            //}
            //Console.WriteLine();
            ////Console.WriteLine(myList[3]);

            Console.ReadLine();
        }
    }
}