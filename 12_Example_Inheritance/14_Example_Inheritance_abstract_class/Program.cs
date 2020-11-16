using System;

namespace _14_Example_Inheritance_abstract_class
{
    abstract class Person
    {
        public string Name { get; set; }

        // Потрібно реалізувати в усіх похідних класах!
        public abstract int Age { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        // Потрібно реалізувати в усіх похідних класах!
        public abstract void Display();
    }

    class Client : Person
    {
        public int Sum { get; set; }    // сума на рахунку

        public override int Age
        {
            get { return Age; }
            set { Age = value+10; }
        }

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} має рахунок на суму {Sum}");
        }
    }

    class Employee : Person
    {
        public string Position { get; set; } // посада

        public override int Age
        {
            get { return Age; }
            set { Age = value+5; }
        }

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine($"Співробітник {Name} є {Position}");
        }
    }

    // Спроба нереалізувати абстрактний метод базового класу 
    // призведе до помилки!
    class EmployeeWithoutMethod : Person
    {
        public string Position { get; set; } // посада

        public override int Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public EmployeeWithoutMethod(string name, string position)
            : base(name)
        {
            Position = position;
        }
       
        public override void Display()
        {
            Console.WriteLine($"Співробітник {Name} є {Position}");
        }
        
    }
    // Спроба визначити абстрактний метод в неабстрактному класі
    // призведе до помилки
    /* class Human
    {
        public string Name { get; set; }
        public abstract void Display();
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Не можливо створити об'єкт від абстрактного класу!
            // Person myPerson = new Person("Василь Петренко");
            
            Client client = new Client("Tom", 500);
            Employee employee = new Employee("Василь", "Інспектор");

            client.Display();
            employee.Display();

            Console.ReadKey();
        }
    }
}
