using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a natural number:");
            number = CheckInput();
            Console.WriteLine($"The sum of digits in number {number} is {MathOperations.FindNumbersSum(number)}");

            string msg = MathOperations.IsOneDigitEven(number) == true ? "has at least one even digit" : "doesn't have even digits";
            Console.WriteLine($"The number {number} {msg}");

            string isPalindrom = MathOperations.IsPalindrom(number) == true ? "is" : "isn't";
            Console.WriteLine($"The number {number} {isPalindrom} palindrom");

            Console.WriteLine($"Maximal digit in number {number} is {MathOperations.FindMaxDigit(number)}");

            int position;
            Console.WriteLine("Enter a position of Fibonacci number:");
            position = CheckInput();

            Console.WriteLine($"The {position} number in Fibonacci sequence is {MathOperations.FindFibonacciNumber(position)}");
        }

        static int CheckInput()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("You enter invalid data!");
            }
            return number;
        }
    }
}
