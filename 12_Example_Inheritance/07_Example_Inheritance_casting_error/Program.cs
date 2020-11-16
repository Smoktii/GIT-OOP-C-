using System;

namespace _07_Example_Inheritance_casting_error
{
    class Person
    {
        // Автовластивість
        public string Name { get; set; }
        // Конструктор
        public Person(string name)
        {
            Name = name;
        }
        // Перевизначення ToString
        public override string ToString()
        {
            return "The Name of Person is " + Name;
        }
    }

    class Employee : Person
    {
        // Автовластивість
        public string Company { get; set; }
        // Конструктор
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public override string ToString()
        {
            return "Employee: Name= " + Name + ", Company = " + Company;
        }
    }
    class Client : Person
    {
        // Автовластивість
        public string Bank { get; set; }
        // Конструктор
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
        public override string ToString()
        {
            return "Client: Name= " + Name + ", Bank = " + Bank;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person person = new Person("Tom");

            // Використовуємо ключове слово as
            Employee emp1 = person as Employee;
            if (emp1 == null)
            {
                Console.WriteLine("Перетворення пройшло невдало");
            }
            else
            {
                Console.WriteLine(emp1.Company);
            }

            // Обробка виключення InvalidCastException
            try
            {
                Employee emp2 = (Employee)person;
                Console.WriteLine(emp2.Company);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Перевірка допустимості перетворення за допомогою ключового слова is 
            if (person is Employee)
            {
                Employee emp3 = (Employee)person;
                Console.WriteLine(emp3.Company);
            }
            else
            {
                Console.WriteLine("Employee emp3 = (Employee)person Перетворення не припустимо ");
            }

            Console.ReadKey();
        }
    }
}
