using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    // Write a function that returns the sum of two numbers.
    class Program
    {
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        static void Main(string[] args)
        {
            var result = Add(15, 23);
            Console.WriteLine("Sum of two integers is: {0}", result);
            Console.WriteLine();
        }
    }
}
