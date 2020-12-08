using System;

namespace TriangleSides
{
    class Program
    {
        delegate void SidesAbility(double a, double b, double c);
        static void Main(string[] args)
        {
            double a = 3.14, b = 5.3, c = 2.43;
            SidesAbility result = DefinesSidesAbility;
            result(a, b, c);
        }

        static void DefinesSidesAbility(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine($"Sides {a}, {b} and {c} cannot be the sides of a triangle");
            }
            else if (a + b > c && a + c > b && c + b > a)
            {
                Console.WriteLine($"Sides {a}, {b} and {c} can be sides of a triangle");
            }
            else
            {
                Console.WriteLine($"Sides {a}, {b} and {c} cannot be the sides of a triangle");
            }
        }
    }
}
