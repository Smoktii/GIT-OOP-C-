using System;

namespace Example_Applied_Aspects
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            int ten = 10;

            // If the previous sum is attempted in a checked environment, an
            // OverflowException error is raised.

            // ERROR at run time: Checked expression.
            // Console.WriteLine(checked(2147483647 + ten));

            // Checked block.
            checked
            {
                // System.OverflowException: "Arithmetic operation resulted in an overflow."
                int i3 = 2147483647 + ten;
                Console.WriteLine(i3);
            } 

            Console.WriteLine($"unchecked(2147483647 + ten) = {unchecked(2147483647 + ten)}");

            unchecked
            {
                // System.OverflowException: "Arithmetic operation resulted in an overflow."
                int i3 = 2147483647 + ten;
                Console.WriteLine($"unchecked block i3 = 2147483647 + ten => {i3}"); 
            }

            Console.ReadKey();

        }
    }
}
