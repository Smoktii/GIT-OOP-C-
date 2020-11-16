using System;

namespace _11_Example_Inheritance_casting_virtual_hiding
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Display()
        {
            Console.WriteLine($"Display in Person: {FirstName} {LastName}");
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string firstName, string lastName, string company)
                : base(firstName, lastName)
        {
            Company = company;
        }
        // Перевизначити неможливо, бо Display - не віртуальний метод
        public new void Display()
        {
            Console.WriteLine($"Display in Employee: {FirstName} {LastName} працює в {Company}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person bob = new Person("Bob", "Robertson");
            bob.Display();      // Bob Robertson

            Employee tom = new Employee("Tom", "Smith", "Microsoft");
            tom.Display();      // Tom Smith працює в Microsoft

            Console.ReadKey();
        }
    }
}
