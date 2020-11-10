using System;

namespace _05_Example_Inheritance_base
{
    class Person
    {
        string name;
        int age;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("In Costructor Person(string name)");
        }
        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("In Costructor Person(string name, int age)");
        }
    }
    class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("In Costructor Employee(string name, int age, string company)");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Employee e = new Employee("Петро", 22, "MySoft"); 

            Console.ReadKey();
        }
    }

}
