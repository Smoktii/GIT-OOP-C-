using System;

namespace _07_Example_Applied_Aspects_Indexers_Get
{
    class MatrixGet
    {
        private int[,] numbers = new int[,] {  { 1, 2, 3 }, 
                                               { 4, 5, 6 }, { 7, 8, 9 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            // set - немає, змінити масив неможливо!
        }
    }

    class MatrixPrivateSet
    {
        private int[,] numbers = new int[,] {  { 1, 2, 3 },
                                               { 4, 5, 6 }, { 7, 8, 9 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            // змінити масив неможливо тільки в методах класу
            private set
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

            MatrixGet matrix1 = new MatrixGet();
            Console.WriteLine($"matrix1[0, 0] = {matrix1[0, 0]}"); // 1 
            // Error - змінити масив неможливо
            // matrix1[0, 0] = 111;
            Console.WriteLine($"matrix1[0, 0] = {matrix1[0, 0]}"); // 111

            MatrixPrivateSet matrix2 = new MatrixPrivateSet();
            Console.WriteLine($"matrix2[0, 0] = {matrix2[0, 0]}"); // 1 
            // Error - змінити масив неможливо
            // matrix2[0, 0] = 111;
            Console.WriteLine($"matrix2[0, 0] = {matrix2[0, 0]}"); // 111

            Console.ReadKey();
        }
    }
}
