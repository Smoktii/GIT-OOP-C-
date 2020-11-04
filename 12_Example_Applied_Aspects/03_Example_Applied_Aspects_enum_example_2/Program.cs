using System;

namespace _03_Example_Applied_Aspects_enum_example_2
{
    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,        // 0
        Monday = 0b_0000_0001,      // 1
        Tuesday = 0b_0000_0010,     // 2
        Wednesday = 0b_0000_0100,   // 4
        Thursday = 0b_0000_1000,    // 8
        Friday = 0b_0001_0000,      // 16
        Saturday = 0b_0010_0000,    // 32
        Sunday = 0b_0100_0000,      // 64
        Weekend = Saturday | Sunday // 0b_0110_0000 = 32+64 = 96
    }

    public enum DaysNotFlags
    {
        None = 0b_0000_0000,        // 0
        Monday = 0b_0000_0001,      // 1
        Tuesday = 0b_0000_0010,     // 2
        Wednesday = 0b_0000_0100,   // 4
        Thursday = 0b_0000_1000,    // 8
        Friday = 0b_0001_0000,      // 16
        Saturday = 0b_0010_0000,    // 32
        Sunday = 0b_0100_0000,      // 64
        Weekend = Saturday | Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            // Output:
            // Monday, Wednesday, Friday
            Console.WriteLine($"meetingDays = Days.Monday | Days.Wednesday | Days.Friday = {meetingDays}");
            Console.WriteLine($"(int) meetingDays = Days.Monday | Days.Wednesday | Days.Friday = {(int)meetingDays}");

            DaysNotFlags meetingDays1 = DaysNotFlags.Monday | DaysNotFlags.Wednesday | DaysNotFlags.Friday;
            // Output:
            // Monday 1, Wednesday 4, Friday 16 = 21           
            Console.WriteLine($"meetingDays1 = DaysNotFlags.Monday | DaysNotFlags.Wednesday | DaysNotFlags.Friday = {meetingDays1}");

            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            // Output:
            // Join a meeting by phone on Friday

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            // Output:
            // Is there a meeting on Tuesday: False

            // Перетворення var на Days
            var a = (Days)37;
            Console.WriteLine($"a = (Days)37 = {a}");
            // Output:
            // Monday (1), Wednesday (4), Saturday (32)

            var a2 = (Days)138;
            Console.WriteLine($"a = (Days)138 = {a2}");
            // Output: 138

            // Використовуйте метод Enum.IsDefined, щоб визначити, чи містить тип перерахування 
            // член перерахування з певним пов'язаним значенням
            Console.WriteLine($"Enum.IsDefined(typeof(Days), 138) = {Enum.IsDefined(typeof(Days), 138)}");
            Console.WriteLine($"Enum.IsDefined(typeof(Days), 4) = {Enum.IsDefined(typeof(Days), 4)}");
            Console.WriteLine($"Enum.IsDefined(typeof(Days), 3) = {Enum.IsDefined(typeof(Days), 3)}");

            Console.ReadKey();
        }
    }
}
