using System;

namespace _13_Example_Inheritance_casting_virtual_hiding_diff
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Display in Person: Name = {Name}");
        }
        public virtual void DisplaySealed()
        {
            Console.WriteLine($"DisplaySealed in Person: Name = {Name}");
        }
        public void DisplayForHiding()
        {
            Console.WriteLine($"DisplayForHiding in Person: Name = {Name}");

        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }
        public override void Display()
        {
            Console.WriteLine($"Display in Employee: {Name} працює в {Company}");
        }
        public override sealed void DisplaySealed()
        {
            Console.WriteLine($"DisplaySealed in Employee: {Name} працює в {Company}");
        }
        public new void DisplayForHiding()
        {
            Console.WriteLine($"DisplayForHiding in Employee: {Name} працює в {Company}");
        }
    }
    class EmployeeSealed : Employee
    {
        public EmployeeSealed(string name, string company)
            : base(name, company)
        {
            ;
        }
        public new void DisplaySealed()
        {
            Console.WriteLine($"DisplayForHiding in EmployeeSealed: {Name} працює в {Company}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person tom = new Employee("Tom", "Microsoft");
            tom.Display();              // Tom працює в Microsoft
            tom.DisplayForHiding();     // Tom

            EmployeeSealed emp = new EmployeeSealed("Bill", "Unnoun");
            tom.DisplaySealed();     // Tom працює в Microsoft

            Console.ReadKey();
        }
    }
}
