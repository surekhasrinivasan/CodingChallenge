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
            int reverse = 0;

            while (num > 0)
            {
                //int remainder = num % 10;
                reverse = (reverse * 10) + num % 10;
                num = num / 10;
            }
            return reverse;
        }
    }
}
