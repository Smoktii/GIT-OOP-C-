using System;

namespace _04._3_Example_Applied_Aspects_array_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            int[,] myArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int count = 0; 
            foreach (int i in myArray)
            {
                count++; 
                Console.Write($"{i} ");
            }
            Console.WriteLine($"count = {count}, myArray.Length = {myArray.Length}");

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            Console.WriteLine($"mas.GetUpperBound(0) = {mas.GetUpperBound(0)}");
            Console.WriteLine($"mas.GetUpperBound(1) = {mas.GetUpperBound(1)}");
            // Error System.IndexOutOfRangeException: "Array does not have that many dimensions."
            // Console.WriteLine($"mas.GetUpperBound(2) = {mas.GetUpperBound(2)}");

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"mas[{i}, {j}] = {mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            // Масив масивів
            int[][] numbers = new int[3][];
            // виділяємо пам'ять для першого підмасива 
            numbers[0] = new int[2] { 1, 2 };
            // виділяємо пам'ять для другого підмасива 
            numbers[1] = new int[3] { 1, 2, 3 };
            // виділяємо пам'ять для третього підмасива 
            numbers[2] = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"foreach (int[] row in numbers)");
            foreach (int[] row in numbers)
            {
                foreach (int element in row)
                {
                    Console.Write($"{element} \t");
                }
                Console.WriteLine();
            }

            // перебір за допомогою циклу for
            Console.WriteLine($"for (int i = 0; i < numbers.Length; i++)"); 
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"numbers[{i}], [{j}] = {numbers[i][j]} \t"); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
