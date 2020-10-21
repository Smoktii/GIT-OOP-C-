using System;

namespace _08_Example_Applied_Aspects_Indexers_overload
{
    class Person
    {
        // Визначення двох автовластивостей
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class People
    {
        // Визначення множини співробітників
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
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
        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
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

            Console.WriteLine($"people[0].Name = {people[0].Name}"); // Tom
            // Чому стоять одинарні лапки? 'Bob'
            Console.WriteLine($"people['Bob'].Name = {people["Bob"].Name}"); // Bob 
 
            Console.ReadKey();
        }
    }
}
