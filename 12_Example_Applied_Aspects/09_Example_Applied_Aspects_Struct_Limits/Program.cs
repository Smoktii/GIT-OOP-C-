using System;

namespace _09_Example_Applied_Aspects_Struct_Limits
{
    // Визначаємо структуру User
    struct User
    {
        public string name;
        public int age;

        // Визначення автовластивості
        static public double X { get; set; }
        public double Y { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }

        // 1. Не можемо визначити конструктор без параметрів
        /* public void User()
        {
            name = "Unnoun";
            age = -1;
        } */

        // 2. Не можемо ініціалізувати поле екземпляра або властивість 
        // при його оголошенні
        // public int ageError = 20;

        // однак можна ініціалізувати статичне поле або поле константи при її оголошенні
        const int g = 10;
        static public double X1 = 20.0;
    }

    struct UserVer2
    {
        public string name;
        public int age;

        // Визначення автовластивості
        static public double X { get; set; }
        public double Y { get; set; }

        //3. Конструктор структури повинен ініціалізувати всі поля.
        public UserVer2(string newName, int newAge)
        {
            name = newName;
            age = newAge;
            X = 3.14;
            Y = 2.72;
            // Коментування любого поля призводить до помилки!
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Визначаємо екземпляр структури User з "пустим" конструктором,
            // якого немає явно в структурі! 
            User tom = new User();
            tom.DisplayInfo();

            tom.name = "Tom";
            tom.age = 34;
            tom.DisplayInfo();

            Console.ReadKey();
        }
    }
}
