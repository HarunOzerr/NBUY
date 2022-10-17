using System.Reflection;

namespace Proje08_Abstract
{
    abstract class Person //Eğer bir class abstract ise o classtan yeni bir nesne yaratılamaz.
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Person is created!");
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Greeting()
        {
            Console.WriteLine("I am a person");
        }
        public abstract void Intro();//Soyut metot
        //Eğer bir classın içinde abstract bir metot var ise, o class da abstract olmalı.

    }
    class Student : Person
    {
        public Student(string firstName, string lastName, int studentNumber) : base(firstName, lastName)
        {
            StudentNumber=studentNumber;
            Console.WriteLine("Student is created.");
        }
        public int StudentNumber { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Student Number: {StudentNumber}");
        }
    }
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string branch) : base(firstName, lastName)
        {
            FirstName=firstName;
            LastName=lastName;
            Branch=branch;
        }
        public string Branch { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Branch: {Branch}");
        }

        public void Teach()
        {
            Console.WriteLine("Hi, I am teaching.");
        }
    }
    class Writer : Person
    {
        public Writer(string firstname, string lastName, string bookName) : base(firstname,lastName)
        {
            Console.WriteLine("Writer is created.");
        }
        public string BookName { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Book Name: {BookName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Harun","Özer",9);
            student1.Greeting();
            student1.Intro();//Not: İstemediğimiz halde Person'daki intro çalışıyor.

            Teacher teacher1 = new Teacher("Harun", "Özer", "Developer");
            teacher1.Greeting();
            student1.Intro();//Not: İstemediğimiz halde Person'daki intro çalışıyor.

            Writer writer1 = new Writer("Math", "Haig", "qwdsad");
            writer1.Greeting();
            writer1.Intro();

            //Person person1 = new Person("Ahmet", "Özer", 154); //Abstract class'a bu şekilde yeni(new) oluşturulamaz.

            Console.ReadLine();
        }
    }
}