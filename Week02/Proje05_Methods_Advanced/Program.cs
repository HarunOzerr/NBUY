namespace Proje05_Methods_Advanced
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Intro()
            {
                return $"Ad: {this.Name}, Yaş: {this.CalculateAge()}";
            }
            private int CalculateAge()
            {
                return DateTime.Now.Year - this.Year;
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Engin", Year = 1975 };
            Person person2 = new Person() { Name = "Harun", Year = 2000 };
            Person person3 = new Person() { Name = "Ahmet", Year = 1991 };
            Person person4 = new Person() { Name = "Mehmet", Year = 1993 };
            Person person5 = new Person() { Name = "Süleyman", Year = 1998 };

            
            Console.WriteLine(person5.Intro());
            //Tüm kişilerin intro bilgilerini ekrana yazdırın.
            Person[] persons = { person1, person2, person3, person4, person5 };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Intro());
            }
            Console.ReadLine();
            //C#'ta her her ŞEY bir NESNEDİR.
        }
    }
}