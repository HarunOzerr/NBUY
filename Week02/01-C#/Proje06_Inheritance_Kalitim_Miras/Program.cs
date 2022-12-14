namespace Proje06_Inheritance_Kalitim_Miras
{
    class Person //Bir class, istenildiği kadar başka classa miras verebilir!
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro() //Virtual keywordü, bu metodun miras alınan classlarda override edilmesine izin verir.
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name {this.LastName}");
        }
    }
    class Student : Person //Bir class, sadece tek bir classtan miras alabilir!
    {
        public int StudentNumber { get; set; }
        public override void Intro() //Bu metodun miras alınan sınıftaki versiyonunu ezip, yok sayıp yerine bu metodu kabul eder!
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name {this.LastName}, Student Number: {this.StudentNumber}");
        }
    }
    class Writer : Person
    {
        public string BookName { get; set; }
    }
    class Teacher : Person
    {
        public string Branch { get; set; }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b : a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    class c : b
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            student.FirstName = "Kemal";
            student.LastName = "Kapucu";
            student.StudentNumber = 125;
            student.Intro();

            // Bir teacher tanımlayın, içini doldurun, ekrana yazdırın.
            Teacher teacher = new Teacher();
            teacher.FirstName = "Harun";
            teacher.LastName = "Özer";
            teacher.Branch = "Yazılım";
            teacher.Intro();


            Person person1 = new Person();
            //Student student1 = new Person(); //Bu yanlış kullanımdır
            Console.ReadLine();

        }
    }
}