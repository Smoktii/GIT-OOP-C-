using System;

namespace _10_Example_Applied_Aspects_Struct_features
{
    // Визначаємо структуру User
    struct User
    {
        public string name;
        public int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Визначаємо екземпляр структури User без використання конструктора
            User tom = new User();
            // Помилка: Використання локальної змінної "tom", якої не присвоєно значення. 
            // int x = tom.age;   
            // Помилка:
            // tom.DisplayInfo();  

            // НЕМАЄ помилки
            User tomCorrect;
            tomCorrect.age = 35;
            tomCorrect.name = "tomCorrect";
            Console.WriteLine($"User tomCorrect з ініціалізацією"); 
            tomCorrect.DisplayInfo();

            // НЕМАЄ помилки, якщо визначаємо екземпляр структури User без використання конструктора
            User tomNew = new User();
            Console.WriteLine($"User tomNew = new User();"); 
            tomNew.DisplayInfo();

            User tomConstructor = new User("Петро", 28);
            Console.WriteLine($"User tomConstructor = new User('Петро', 28);");
            tomConstructor.DisplayInfo();

            // можна використовувати ініціалізатор для створення структури
            User person = new User { name = "Sam", age = 31 };
            Console.WriteLine($"User person = new User {{ name = \"Sam\" , age = 31 }}");
            person.DisplayInfo();

            Console.ReadKey();
        }
    }
}
