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
    class EmpoyeeChild : Employee 
    {
        public override string ToString()
        {
            return "In EmpoyeeChild Name = " + Name + ", Salary = " + Salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;


            Employee e1 = new Employee { Name = "Tom" };
            Employee e2 = new Employee();
            Employee e3 = new Employee("Василь", 10000.00);

            Console.WriteLine($"e1 = {e1.ToString()}");
            Console.WriteLine($"e2 = {e2.ToString()}");
            Console.WriteLine($"e3 = {e3.ToString()}");
            
            Employee e4 = e1 + e2 + e3;
            Console.WriteLine($"e4 = e1 + e2 + e3 = {e4.ToString()}");
            Console.WriteLine($"e4 = e1 + e2 + e3 = {e4}");

            EmpoyeeChild ec1 = new EmpoyeeChild { Name = "Tom_Child" };
            EmpoyeeChild ec2 = new EmpoyeeChild();
            // Error
            // EmpoyeeChild ec3 = new EmpoyeeChild("Василь", 10000.00);
            // Error
            // EmpoyeeChild ec4 = (ec1 + ec2);
            Employee ec3 = (ec1 + ec2);

            Console.WriteLine($"ec1 = {ec1.ToString()}");
            Console.WriteLine($"ec2 = {ec2.ToString()}");
            Console.WriteLine($"ec3 = ec1 + ec2 = {ec3.ToString()}");

            Console.ReadKey();
        }
    }
}
