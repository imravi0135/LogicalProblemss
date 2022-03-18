using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs");
            Console.WriteLine("Enter The Program Number to get Execute \n1.Fibonacci Series \n2.Perfect Number");
            int Option;
            Option = Convert.ToInt32(Console.ReadLine());
             
            switch(Option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Fibo();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Perfect();
                    break;

            }
            Console.ReadLine();
        }
    }
}
