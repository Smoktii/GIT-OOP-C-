using System;

namespace _12_Example_Inheritance_01
{
    class office
    {
        public string AdresOffice
        {
            get;
            set;
        }
    }
    class Person
    {
        private string _name;
        protected string _nameProtected;

        public string Name
        {
            get { return _name; }
            set { _name = value; _nameProtected = value; }
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
            // Неможливо
            // Console.WriteLine($"Name = {_name}");
            // можливо
            Console.WriteLine($"_nameProtected = {_nameProtected}");
        }

        static public Employee operator +(Employee a, Employee b)
        {
            Employee resultEmployee = new Employee();
            resultEmployee.Name = a.Name + " - " + b.Name;
            resultEmployee.Salary = a.Salary + b.Salary;
            return resultEmployee;
        }
        public Employee(string cName = "Невідомий", double cSalary = -100.00)
        {
            Name = cName;
            Salary = cSalary;
            Console.WriteLine($"In Constructor Employee()");
        }
        // Перевизначення (перегрузка-переопределение)
        public override string ToString()
        {
            return "Name = " + Name + ", Salary = " + Salary;
        }
    }
    sealed class EmployeeSealed : Employee
    {
       
        public bool SuperStar 
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "In EmployeeSealed Name = " + Name + ", Salary = " + Salary;
        }
        public EmployeeSealed(string name, double salary, bool superStar)
               : base(name, salary)
        {
            SuperStar = superStar;
            Console.WriteLine($"In Constructor EmployeeSealed()");
        }

    }

    // Спроба наслідування
    // class EmployeeSuper : EmployeeSealed { }

    // Спроба наслідування множинного наслідування
    // class EmpoyeeTest : Employee, office { }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            EmployeeSealed es1 = new EmployeeSealed("Петро", 25000.00, true) ;
            Console.WriteLine($"es1 = {es1.ToString()}");

            Console.ReadKey();
        }
    }
}
