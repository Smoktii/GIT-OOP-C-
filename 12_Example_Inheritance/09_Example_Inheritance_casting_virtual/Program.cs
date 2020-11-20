using System;

namespace _09_Example_Inheritance_casting_virtual
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($" Конструктор в Person");
        }
        // Можливо для перевизначення Display()
        public virtual void Display()
        {
            Console.WriteLine($"Display in class Person: Name - {Name}"); 
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
            Console.WriteLine($" Конструктор в Employee");
        }
    }

    class SuperEmployee : Employee
    {
        public SuperEmployee(string name, string company)
            : base(name, company)
        {
            Console.WriteLine($" Конструктор в SuperEmployee");
        }
        public override void Display()
        {
            Console.WriteLine($"Display in SuperEmployee: {Name} працює в {Company}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person p1 = new Person("Bill");
            // Person p1 = new Person { Name = "Bill" };
            p1.Display(); // виклик методу Display з класу Person

            Employee p2 = new Employee("Tom", "Microsoft");
            p2.Display(); // виклик методу Display з класу Person

            SuperEmployee p3 = new SuperEmployee("Jack", "Google");
            p3.Display(); // виклик методу Display з класу SuperEmployee

            Console.ReadKey();
        }
    }
}
