using System;

namespace YearTime
{
    class Program
    {
        delegate void YearTime(int number);
        static void Main(string[] args)
        {
            int DayNumber;
            Console.WriteLine("Enter a number of month: ");
            if (!int.TryParse(Console.ReadLine(), out DayNumber))
            {
                Console.WriteLine("You enter invalid data!");
            }
            else
            {
                YearTime result = DefinesYearTime;
                result(DayNumber);
            }
        }

        static void DefinesYearTime(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("It is winter!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It is spring!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It is summer!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It is autumn!");
                    break;
                default:
                    Console.WriteLine($"The number {monthNumber} does not fall in the range from 1 to 12");
                    break;
            }
        }
    }
}
