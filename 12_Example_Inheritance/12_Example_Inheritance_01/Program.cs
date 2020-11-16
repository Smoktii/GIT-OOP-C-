using System;

namespace _12_Example_Inheritance_01
{
    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Name = {_name}"); 
        }
    }
    class Employee : Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Name = {Name}, Salary = {Salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person p = new Person { Name = "Tom" };
            //Person p = new Person();
            // p.Name = "Tom";
            p.Display();
            Console.WriteLine($"Type of 'p': {p.GetType()}");

            Employee e = new Employee { Name = "Tom_Employee", Salary = 10000.00 };
            e.DisplayEmployee();
            // Можливо визвати метод Display()?
            Console.WriteLine($"Перевірка визову е.Display() для Tom_Employee");
            e.Display();
           
            Console.WriteLine($"Type of 'e': {e.GetType()}");
            Console.WriteLine($"e.Salary = {e.Salary}");

            // Об'єкт класу Employee є Об'єктом класу Person (згідно наслудівання) 
            p = new Employee { Name = "Sam", Salary = 15000.00 };
            p.Display();
            
            Console.WriteLine($"p = new Employee...  p.ToString() = {p.ToString()}");

            // Можливо визвати метод DisplayEmployee()?
            // p.DisplayEmployee();
            // Можливо визвати метод p.Salary()?
            // Console.WriteLine($"p.Salary = {p.Salary}");

            Console.WriteLine($" p = new Employee... Type of 'p': {p.GetType()}");

            Console.ReadKey();
        }
    }
}
