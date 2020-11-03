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
            people[1].Age = 21;

            Console.WriteLine($"people[0].Name = {people[0].Name}"); // Tom
            Console.WriteLine($"people[0].Age = {people[0].Age}"); // ?
            // Чому стоять одинарні лапки? 'Bob'
            Console.WriteLine($"people['Bob'].Name = {people["Bob"].Name}, people['Bob'].Age = {people["Bob"].Age}"); // Bob 
            Console.WriteLine($"people['Bob1'].Name = {people["Bob1"]?.Name}, people['Bob1'].Age = {people["Bob1"]?.Age}"); // Bob1 

            Console.ReadKey();
        }
    }
}
