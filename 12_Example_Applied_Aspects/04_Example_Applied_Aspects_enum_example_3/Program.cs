using System;

namespace _04_Example_Applied_Aspects_enum_example_3
{
    [Flags]
    public enum PetType
    {
        None = 0, Dog = 1, Cat = 2, Rodent = 4, Bird = 8, Reptile = 16, Other = 32
    };
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            object value;

            // Call IsDefined with underlying integral value of member.
            value = 1;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       1: True

            // Call IsDefined with invalid underlying integral value.            
            value = 64;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       64: False

            // Call IsDefined with string containing member name.
            value = "Rodent";
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       Rodent: True

            // Call IsDefined with a variable of type PetType.
            value = PetType.Dog;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       Dog: True

            value = PetType.Dog | PetType.Cat;
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       Dog, Cat: False

            // Call IsDefined with uppercase member name.
            value = "None";
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       None: True

            value = "NONE";
            Console.WriteLine("{0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       NONE: False

            // Call IsDefined with combined value
            value = PetType.Dog | PetType.Bird;
            Console.WriteLine("{0:D}, {0}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       9, Dog, Bird: False

            value = value.ToString();
            // value = "Dog, Bird"
            Console.WriteLine("{0:D}: {1}", value, Enum.IsDefined(typeof(PetType), value));
            //       Dog, Bird: False

            Console.ReadKey();
        }
    }
    // The example displays the following output:
    //       1: True
    //       64: False
    //       Rodent: True
    //       Dog: True
    //       Dog, Cat: False
    //       None: True
    //       NONE: False
    //       9: False
    //       Dog, Bird: False
}
