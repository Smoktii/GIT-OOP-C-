using System;

namespace _06_Example_Applied_Aspects_Indexers_2
{
    class Matrix
    {
        private int[,] numbers = new int[,] {   { 1, 2, 3 }, 
                                                { 4, 5, 6 }, { 7, 8, 9 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            set
            {
                numbers[i, j] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Matrix matrix = new Matrix();
            Console.WriteLine($"matrix[0, 0] = {matrix[0, 0]}"); // 1 
            matrix[0, 0] = 111;
            Console.WriteLine($"matrix[0, 0] = {matrix[0, 0]}"); // 111

            Console.ReadKey();
        }
    }
}
