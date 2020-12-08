using System;

namespace The_Greatest
{
    class Program
    {
        delegate void MaxMin();
        static void Main(string[] args)
        {
            MaxMin result = FindMaxMin;
            result();
        }

        static void FindMaxMin()
        {
            double number;
            double max = double.MinValue;
            double min = double.MaxValue;
            bool equality = false;
            Console.WriteLine("Enter numbers (if you would like to stop, enter any letter): ");
        Condition:
            if (double.TryParse(Console.ReadLine(), out number))
            {
                max = max < number ? number : max;
                min = min > number ? number : min;
                equality = min == max;
                goto Condition;
            }
            string msg;
            if (equality)
            {
                msg = "All numbers are equal";
            }
            else
            {
                msg = $"The greatest number is {max}. The smallest number is {min}";
            }
            Console.WriteLine(msg);
        }
    }
}
