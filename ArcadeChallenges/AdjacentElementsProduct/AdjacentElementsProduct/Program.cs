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
     * An array of integers containing at least two elements.
     * Guaranteed constraints:
     * 2 ≤ inputArray.length ≤ 10,
     * -1000 ≤ inputArray[i] ≤ 1000.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //int[] inputarr = { -23, 4, -3, 8, -12 };
            //Console.WriteLine("The largest product is: {0}", AdjacentElementsProductKata.adjacentElementsProduct(inputarr));

            Console.WriteLine("Enter the numbers of the array: ");

            int[] inputarr1 = new int[6];
            for (int i = 0; i < 6; i++)
            {
                inputarr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(AdjacentElementsProductKata.adjacentElementsProduct(inputarr1));
            Console.WriteLine();
        }
    }
}
