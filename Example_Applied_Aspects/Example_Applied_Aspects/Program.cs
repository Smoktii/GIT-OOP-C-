﻿using System;

namespace Example_Applied_Aspects
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // The following example causes compiler error CS0220 because 2147483647
            // is the maximum value for integers.
            //int i1 = 2147483647 + 10;

            // The following example, which includes variable ten, does not cause
            // a compiler error.
            int ten = 10;
            int i2 = 2147483647 + ten;

            // By default, the overflow in the previous statement also does
            // not cause a run-time exception. The following line displays
            // -2,147,483,639 as the sum of 2,147,483,647 and 10.
            Console.WriteLine($"-2,147,483,639 not 2,147,483,657 = {i2}");

            Console.ReadKey();
        }
    }
}
