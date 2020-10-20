using System;

namespace _02.Example_method_overloading_implicit
{
    public class Digit
    {
        private byte digit;

        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
            }
            this.digit = digit;
        }

        public static implicit operator byte(Digit d)
        {
            return d.digit;
        }
        public static explicit operator Digit(byte b)
        {
            return new Digit(b);
        }

        public override string ToString() 
        { 
            return $"{digit}"; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            var d = new Digit(7);

            byte number = d;
            Console.WriteLine(number);  // output: 7

            Digit digit = (Digit)number;
            Console.WriteLine(digit);  // output: 7

            Console.ReadKey();
        }
    }
}
