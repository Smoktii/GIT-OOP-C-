using System;

namespace _01_Example_Applied_Aspects_null
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            object o = null;
            string s = null;

            Console.WriteLine($"o = {o}");
            Console.WriteLine($"s = {s}");

            object x = null;
            object y = x ?? 100;  // дорівнює 100, так як x дорівнює null
            Console.WriteLine($"y = {y}");

            object z = 200;
            object t = z ?? 44; // дорівнює 200, так як z не дорівнює null
            Console.WriteLine($"t = {t}");

            int x1 = 44;
            // змінна x представляє значний тип int і не може приймати значення null, 
            // тому в якості лівого операнда в операції ?? вона використовуватися не може
            // int y1 = x1 ?? 100;  

            Console.ReadKey();
        }
    }
}
