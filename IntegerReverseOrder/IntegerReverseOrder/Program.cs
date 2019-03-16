using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerReverseOrder
{
    // create a function that will take an integer and reverse the order
    // ex
    // Input: 21445 Output : 54412
    // Input: 145263 Output : 362541
    // Input: 1254859723 Output: 3279584521

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be reversed: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = ReverseOrderKata.ReversedOrder(num);
            Console.WriteLine("Reversed number is :  {0}", result);
        }
    }
}
