using System;

namespace Example_Class
{
    class Person
    {
        public string name; // ім'я
        public int age;     // вік

        public Person() { name = "Невідомо"; age = 18; }      // 1 конструктор

        public Person(string n) { name = n; age = 18; }         // 2 конструктор

        public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

        public void GetInfo()
        {
            Console.WriteLine($"ім'я: {name}  вік: {age}");
        }

        public int SetAge(int a)
        {
            if (a >= 0)
                age = a;
            return 1;
        }
        public int GetAge()
        {
            return age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person tom = new Person();          // виклик 1-го конструктора без параметрів
            Person bob = new Person("Bob");     // виклик 2-го конструктора з одним параметрім
            Person sam = new Person("Sam", 25); // виклик 3-го конструктора з двумя параметрами


            bob.GetInfo();          // ім'я: Bob  вік: 18
            tom.GetInfo();          // ім'я: Невідомо  вік: 18
            sam.GetInfo();          // ім'я: Sam  вік: 25

            Console.ReadKey();
        }
    }
}
