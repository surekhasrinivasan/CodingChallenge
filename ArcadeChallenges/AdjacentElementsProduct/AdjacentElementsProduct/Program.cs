using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentElementsProduct
{
    /* Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
     * Example
     * For inputArray = [3, 6, -2, -5, 7, 3], the output should be adjacentElementsProduct(inputArray) = 21.
     * 7 and 3 produce the largest product.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputarr = { 2, 3, 4, 5, 3, 4 };
            Console.WriteLine("The largest product is: {0}", AdjacentElementsProductKata.adjacentElementsProduct(inputarr));
        }
    }
}
