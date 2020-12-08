using System;

namespace Multiplicity
{
    class Program
    {
        delegate void Multiplicity(int number);
        static void Main(string[] args)
        {
            int number;
            Multiplicity result;
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                result = CalculateMultiplicity;
                result(number);
            }
            else
            {
                Console.WriteLine("You enter invalid data!");
            }
        }

        static void CalculateMultiplicity(int number)
        {
            string msg;
            if (number % 2 == 0)
            {
                msg = $"The number {number} is a multiple of a number {2}";
            }
            else if (number % 3 == 0)
            {
                msg = $"The number {number} is a multiple of a number {3}";
            }
            else if (number % 5 == 0)
            {
                msg = $"The number {number} is a multiple of a number {5}";
            }
            else if (number % 7 == 0)
            {
                msg = $"The number {number} is a multiple of a number {7}";
            }
            else if (number % 11 == 0)
            {
                msg = $"The number {number} is a multiple of a number {11}";
            }
            else if (number % 13 == 0)
            {
                msg = $"The number {number} is a multiple of a number {13}";
            }
            else if (number % 17 == 0)
            {
                msg = $"The number {number} is a multiple of a number {17}";
            }
            else if (number % 19 == 0)
            {
                msg = $"The number {number} is a multiple of a number {19}";
            }
            else{
                msg = $"The number {number} is not a multiple of a numbers {(2, 3, 5, 7, 11, 13, 17, 19)}";
            }
            Console.WriteLine(msg);
        }
    }
}
