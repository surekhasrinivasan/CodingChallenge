using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerReverseOrder
{
    public static class ReverseOrderKata
    {
        public static int ReversedOrder(int num)
        {
            // write the code here
            int reverse = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                Console.WriteLine("remainder: " + remainder);
                reverse = (reverse * 10) + remainder;
                Console.WriteLine("reverse: " +reverse);
                num = num / 10;
                Console.WriteLine("num: " +num);
            }

            return reverse;
        }
    }
}
