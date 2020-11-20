using System;

namespace _10_Example_Inheritance_casting_virtual_02
{
    class Credit
    {
        public virtual decimal Sum { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Display in Class Credit. Sum = {Sum}");
        }
    }
    class LongCredit : Credit
    {
        private decimal sum;
        public override decimal Sum
        {
            get
            {
                return sum;
            }
            set
            {
                if (value > 1000)
                {
                    sum = value;
                }
            }
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Display in LongCredit!!! Sum = {Sum}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            LongCredit credit1 = new LongCredit { Sum = 6000 };
            credit1.Sum = 490;
            Console.WriteLine($"credit1.Sum = {credit1.Sum}"); // 6000

            Credit credit2 = new Credit { Sum = 7000 };
            credit2.Sum = 690;
            Console.WriteLine($"credit2.Sum = {credit2.Sum}"); // 690

            Credit credit3 = new LongCredit { Sum = 8000 };
            credit3.Sum = 790;
            Console.WriteLine($"credit3.Sum = {credit3.GetType()}");
            Console.WriteLine($"credit3.Sum = {credit3.Sum}");
            // Чому буде 8000?

            Console.WriteLine($"\nПриклад використання base в методі Display()\n");
            Console.WriteLine($"\ncredit1.Display(), LongCredit credit1 = new LongCredit"); 
            credit1.Display();
            Console.WriteLine($"\ncredit2.Display(),  Credit credit2 = new Credit"); 
            credit2.Display();
            Console.WriteLine($"\ncredit3.Display(),  Credit credit3 = new LongCredit");
            credit3.Display();

            // Заборона перевизначення методів 
            // Розкоментувати клас LongCreditTryOverrideDisplay 

            Console.ReadKey();
        }
    }

    class LongCreditSealedDisplay : LongCredit
    {
        public override sealed void Display()
        {
            base.Display();
            Console.WriteLine($"Display in LongCreditSealedDisplay (Sealed)! Sum = {Sum}");
        }
    }
    class LongCreditTryOverrideDisplay : LongCreditSealedDisplay
    {
        /*
         * public override void Display()
        {
            Console.WriteLine($"Display in LongCreditTryOverrideDisplay! Sum = {Sum}");
        }
        */
    }
}
