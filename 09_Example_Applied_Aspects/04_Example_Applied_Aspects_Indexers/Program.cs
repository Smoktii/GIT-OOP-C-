using System;

namespace _04_Example_Applied_Aspects_Indexers
{
    class Person
    {
        // Визначимо автовластивість
        public string Name { get; set; }
    }
    class People
    {
        // Визначимо множину персон 
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        // индексатор
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            People people = new People();
            // Для ініціалізації об'єктів класів застосовується ініціалізатор
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };

            Person tom = people[0];
            Console.WriteLine($"tom?.Name (people[0]) = {tom?.Name}");
            Person unnoun = people[3];
            Console.WriteLine($"unnoun?.Name (people[3]) = {unnoun?.Name}");
            // Чи буде працювати? 
            // Person test = people[7];
            // Console.WriteLine($"test?.Name (people[7]) = {test?.Name}");

            Console.ReadKey();
        }
    }
}
