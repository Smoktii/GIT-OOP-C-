using System;

namespace _06_Example_Inheritance_casting
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

            Employee employee = new Employee("Tom", "Microsoft");
            // Висхідні перетворення (англ. Upcasting). 
            // Перетворення від Employee до Person. Проводиться автоматично!
            // так як Employee успадковується від класу Person, 
            // то автоматично виконується неявне висхідний перетворення - 
            // перетворення до типу, які знаходяться вгорі ієрархії класів, 
            // тобто до базового класу
            Person person = employee;

            Console.WriteLine($"person.ToString() = {person.ToString()}");
            // Перевіримо, що в об'єктах класу Employee є ToString()
            Console.WriteLine($"employee.ToString() = {employee.ToString()}");

            // об'єкт person класу Person не бачить поля Company 
            // в об'єкті employee класу Employee
            Console.WriteLine($"employee.Company = {employee.Company}");
            Console.WriteLine($"employee.GetType() = {employee.GetType()}");
            Console.WriteLine($"person.GetType() = {person.GetType()}");
            // Console.WriteLine($"person.Company = {person.Company}");

            // перетворення від Client до Person
            Person person2 = new Client("Bob", "SuperBank");

            // Приклади висхідного неявного перетворення 
            // Тому що тип object - базовий для всіх інших типів, то перетворення до нього
            // буде проводитися автоматично.
            object personA = new Employee("Tom", "Microsoft");  // від Employee до object
            object personB = new Client("Bob", "SuperBank");  // від Client до object
            object personC = new Person("Sam");                 // від Person до object

            /***************************************/
            // Спадні перетворення. Downcasting

            Employee employeeNew = new Employee("Tom", "Microsoft");
            // Можливо висхідне перетворення (англ. Upcasting) від Employee до Person
            Person personNew = employeeNew;

            // так не можна, потрібно явне перетворення
            // Не кожна персона (людина) є співробітником
            // Employee employeeNew2 = personNew; 

            // перетворення від Person до Employee
            Employee employeeNew2 = (Employee)personNew;

            // Об'єкт Employee також представляє тип object
            object obj = new Employee("Bill", "Microsoft");

            // щоб звернутися до можливостей типу Employee, наводимо об'єкт до типу Employee
            Employee emp = (Employee)obj;

            // об'єкт Client також представляє тип Person
            Person personClient = new Client("Sam", "SuperBank");
            // перетворення від типу Person до Client
            Client client = (Client)personClient;

            // Person myPerson1 = new Person("Василь");
            // Client myclient1 = (Client)myPerson1;

            Console.WriteLine($"obj.GetType() = {obj.GetType()}");
            // перетворення до типу Person для виклику методу ToString
            Console.WriteLine($" ((Person)obj).ToString() = {((Person)obj).ToString()}");
            // перетворення до типу Employee для виклику методу ToString
            Console.WriteLine($" ((Employee)obj).ToString() = {((Employee)obj).ToString()}");
            Console.WriteLine($" obj.ToString() = {obj.ToString()}");

            // Помилка. Чому? 
            //Console.WriteLine($" ((Person)obj).Company = {((Person)obj).Company}");

            // Все ОК
            Console.WriteLine($" ((Employee)obj).Company = {((Employee)obj).Company}");

            // перетворення до типу Employee, щоб отримати властивість Company
            string infoCompany = ((Employee)obj).Company;

            // Помилка! Чому?
            object objEmployee = new Employee("Bill", "Microsoft");
            // перетворення до типу Client, щоб отримати властивість Bank
            // string bank = ((Client)objEmployee).Bank;

            // Помилка! Чому?
            // Employee empPerson = new Person("Tom"); 

            // Помилка! Чому?
            // Person personPerson = new Person("Bob");
            // Employee emp2 = (Employee) personPerson; 

            Console.ReadKey();
        }
    }
}
