using System;

namespace Lab_4
{
    class Program
    {
        delegate void HeadsAmount(int years);
        static void Main(string[] args)
        {
            var dragon = new Dragon() { Years = 398 };
            HeadsAmount heads = CalculateHeads;
            heads(dragon.Years);
        }

        static void CalculateHeads(int years)
        {
            const int ThreeHundredYears = 300;
            const int TwoHundredYears = 200;
            const int OneHundredYears = 100;
            var HeadsAmount = 3;
            if (years <= TwoHundredYears)
            {
                HeadsAmount += years * 3;
            }
            else if (years > TwoHundredYears && years <= ThreeHundredYears)
            {
                HeadsAmount += TwoHundredYears * 3 + (years - TwoHundredYears) * 2;
            }
            else
            {
                HeadsAmount += TwoHundredYears * 3 + OneHundredYears * 2 + (years - OneHundredYears - TwoHundredYears);
            }
            Console.WriteLine($"The dragon is {years} years old!\r\nThe number of heads is {HeadsAmount}. The number of eyes is {HeadsAmount * 2}");
        }
    }
}
