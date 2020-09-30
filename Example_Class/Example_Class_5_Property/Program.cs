using System;

namespace Example_Class_5_Property
{
    class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        
        private int age;

        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Вік повинен бути більше 17");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Person p = new Person();

            // Встановлюємо властивість - спрацьовує блок Set
            // значення "Tom" і є передане в властивість value
            p.Name = "Tom";

            // Отримуємо значення властивості і присвоюємо його змінної - спрацьовує блок Get
            string personName = p.Name;
            Console.WriteLine($"personName = {personName}");

            p.Age = 13;
            Console.WriteLine($"p.Age (13) = {p.Age}"); // 0 

            p.Age = 23;
            Console.WriteLine($"p.Age (23) = {p.Age}"); // 23

            Console.ReadKey();
        }
    }
}
