using System;

namespace _08_Example_Applied_Aspects_Struct
{
    // Визначаємо структуру User
    struct User
    {
        public string name;
        public int age;

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

            // Визначаємо екземпляр структури User 
            User tom;
            tom.name = "Tom";
            tom.age = 34;
            tom.DisplayInfo();

            Console.ReadKey();
        }
    }
}
