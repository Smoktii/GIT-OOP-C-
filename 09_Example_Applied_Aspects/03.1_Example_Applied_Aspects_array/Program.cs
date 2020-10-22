using System;

namespace _03._1_Example_Applied_Aspects_array
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Приклади оголошення одномірних масивів
            int[] nums1;
            int[] nums2 = new int[4];
            int[] nums3 = new int[4] { 1, 2, 3, 4 };
            int[] nums4 = new int[] { 1, 2, 3, 4 };
            int[] nums5 = new[] { 1, 2, 3, 4 };
            int[] nums6 = { 1, 2, 3, 4 };

            Console.WriteLine($"nums2[0] = {nums2[0]}");

            string[] weekDays1 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Ініціалізація та можливі помилки
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
            // array3 = {1, 3, 5, 7, 9};   // Error

            int[] nums = new int[4];
            // int[] nums3 = new int[4] { 1, 2, 3, 5 };
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 5;
            Console.WriteLine($"nums[3] = {nums[3]}");  // 5

            // приклад коду, що створює масив з int елементів, 
            // потім ініціалізує цей масив і виводить вміст масиву.

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }

            int[,] doublenums1;
            int[,] doublenums2 = new int[2, 3];
            int[,] doublenums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] doublenums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5} };
            int[,] doublenums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] doublenums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,,] array1 = new int[2, 3, 4];

            Console.ReadKey();
        }
    }
}
