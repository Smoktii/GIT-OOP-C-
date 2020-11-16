using System;

namespace _12_Example_Inheritance_casting_virtual_hiding_Property
{
    class Person
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Employee : Person
    {
        // Приховуємо властивість Name базового класу та визначаємо нову
        public new string Name
        {
            // Використовуємо реалізацію властивості в базовому класі
            get { return "Employee " + base.Name; }
            // Доступ до змінної name є, так як вона protected
            set { name = value; }
        }
    }
    class ExampleBase
    {
        public readonly int x = 10;
        public const int G = 5;
    }
    class ExampleDerived : ExampleBase
    {
        public new readonly int x = 20;
        public new const int G = 15;
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
  
            Person bob = new Person { Name = "Bob Robertson" };
            Console.WriteLine($"Person bob: {bob.Name}");

            Employee tom = new Employee { Name = "Tom Smith" };
            Console.WriteLine($"Employee tom: {tom.Name}");

            // приховування змінних та констант

            ExampleBase myExampleBase = new ExampleBase();
            Console.WriteLine($"myExampleBase: x = {myExampleBase.x}, G = {ExampleBase.G} ");

            ExampleDerived myExampleDerived = new ExampleDerived();
            Console.WriteLine($"myExampleDerived: x = {myExampleDerived.x}, G = {ExampleDerived.G} ");

            ExampleBase myExampleBaseDerived = new ExampleDerived();
            // Чому дорівнює х?
            Console.WriteLine($"myExampleBaseDerived.GetType() = {myExampleBaseDerived.GetType()}");
            Console.WriteLine($"myExampleBaseDerived: x = {myExampleBaseDerived.x}");

            Console.ReadKey();
        }
    }
}
