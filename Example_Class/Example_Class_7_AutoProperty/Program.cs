using System;

namespace Example_Class_7_AutoProperty
{
    class Person
    {
        public string Name { get; set; } = "Tom";
        public int Age { get; set; } = 23;
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person person = new Person();
            Console.WriteLine($"person.Name = {person.Name}"); // Tom
            Console.WriteLine($"person.Age = {person.Age}");  // 23

            Console.ReadKey();
        }
    }
    class Person2
    {
        public string Name { private set; get; }
        public Person2(string n)
        {
            Name = n;
        }
    }

    class Person3
    {
        public string Name { get; } = "Tom";
    }
}
