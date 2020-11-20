using System;

namespace _05_Example_Applied_Aspects_lambda_02
{
    class Program
    {
        // визначаємо делегат, що приймає int і повертає int
        delegate int Square(int x);
        // визначаємо делегат без параметрів
        delegate void Hello();
        // визначаємо делегат с параметром ref
        delegate void ChangeHandler(ref int x);
        // визначаємо делегат
        delegate bool IsEqual(int x);

        private static void Show_Message()
        {
            Console.WriteLine("Привіт, ДонНУ!");
        }

        // визначаємо функцію для прийняття параметрів лябда-виразу
        private static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            // об'єкту делегата присвоюється лямбда-вираз 
            // (з одним параметром та опущеними дужками)
            Square square = i => i * i; 

            int z = square(6); // використовуємо делегат
            Console.WriteLine($"z = {z}"); // 36

            // Використання лямбда-виразів без параметрів
            Hello hello1 = () => Console.WriteLine("Hello");
            Hello hello2 = () => Console.WriteLine("Welcome");
            hello1();       // Hello
            hello2();       // Welcome

            // Використання лямбда-виразів з параметром ref
            int x = 9;
            ChangeHandler ch = (ref int n) => n = n * 2;
            ch(ref x);
            Console.WriteLine($"x, ch(ref x) = {x}"); // 18

            // Лямбда-вирази виконують інші методи
            Hello message = () => Show_Message();
            message(); // "Привіт, ДонНУ!"

            // лямбда-вираз передаємо в якості аргументів методу 
            // для тих параметрів, які представляють делегат
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // знайдемо суму чисел більше 5
            int result1 = Sum(integers, x => x > 5);
            Console.WriteLine($"result1 = {result1}"); // 6+7+8+9 = 30

            // знайдемо суму парних чисел
            int result2 = Sum(integers, x => x % 2 == 0);
            Console.WriteLine($"result2 = {result2}"); // 2+4+6+8 = 20


            Console.ReadKey();
        }
    }
}
