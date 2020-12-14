using System;

namespace Lab_5
{
    class MathOperations
    {
        public static int FindNumbersSum(int number)
        {
            int sum = 0;
            while (number >= 1)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public static bool IsOneDigitEven(int number)
        {
            bool result = false;
            while (number >= 1)
            {
                if (number % 10 % 2 == 0)
                {
                    result = true;
                    break;
                }
                number /= 10;
            }
            return result;
        } 

        public static bool IsPalindrom(int number)
        {
            if (number > 0 && number < 10)
            {
                return true;
            }
            int numberLeft = number;
            int numberRight = 0;
            while (number >= 1)
            {
                numberRight *= 10;
                numberRight += number % 10;
                number /= 10;
            }
            if (numberLeft == numberRight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int FindMaxDigit(int number)
        {
            int maxDigit = 0;
            while (number >= 1)
            {
                if (maxDigit < number % 10)
                {
                    maxDigit = number % 10;
                }
                number /= 10;
            }
            return maxDigit;
        }

        public static int FindFibonacciNumber(int position)
        {
            if (position == 1)
            {
                return 0;
            }
            else if (position == 2)
            {
                return 1;
            }
            return FindFibonacciNumber(position - 1) + FindFibonacciNumber(position - 2);
        }
    }
}
