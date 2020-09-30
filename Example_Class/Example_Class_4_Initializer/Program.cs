using System;

namespace Example_Class
{
    class Person
    {
        public string name; // ім'я
        public int age;     // вік

        public Person() : this("Невідомо")
        {
            Console.WriteLine($"In Person()");
        }
        public Person(string name) : this(name, 18)
        {
            Console.WriteLine($"Person(string name)");
        }
        public Person(string name, int age)
        {
            /******************************* 
            І щоб розмежувати параметри і поля класу, до полів класу звернення йде через ключове слово this.
            Так, в вираженні this.name = name; перша частина this.name означає, що name - це поле поточного класу, 
            а не назву параметра name. Якби параметри і поля називалися по-різному, то використовувати слово this було б необов'язково.
            ********************************/
            this.name = name;
            this.age = age;
            Console.WriteLine($"Person(string name, int age)");
        }

        public void GetInfo()
        {
            Console.WriteLine($"ім'я: {name}  вік: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person tom = new Person();          // виклик 1-го конструктора без параметрів
            Person tom2 = new Person { age = 31 }; // виклик 1-го конструктора без параметрів + ініціалізатор

            tom.GetInfo();          // ім'я: Невідомо  вік: 18
            tom2.GetInfo();          // ім'я: Невідомо  вік: 18

            Console.ReadKey();
        }
    }
}
