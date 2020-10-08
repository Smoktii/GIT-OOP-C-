using System;

namespace Example_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            int a=0;
            int b = 9;
            Sum(a, b);  // Помилка - змінної a не присвоєно значення

            Display("Tom", 24); // Name: Tom  Age: 24
            // Display(45, "Bob"); // Помилка! невідповідність значень типам параметрів


            Console.ReadKey();
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
