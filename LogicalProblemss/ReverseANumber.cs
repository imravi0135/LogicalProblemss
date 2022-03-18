using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemss
{
    internal class ReverseANumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            int rem;
            for (int i = number; number > 0; i--)
            {
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number /= 10;
            }
            Console.WriteLine($"Reverse is: {reverse}");
        }
    }

}
