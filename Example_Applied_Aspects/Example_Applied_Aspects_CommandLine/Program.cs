using System;

namespace Example_Applied_Aspects_CommandLine
{
    class CommandLine
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            // The Length property provides the number of array elements.
            Console.WriteLine($"parameter count = {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }

            Console.ReadKey();
        }
    }
    /* Output (assumes 3 cmd line args):
        parameter count = 3
        Arg[0] = [a]
        Arg[1] = [b]
        Arg[2] = [c]
    */
}
