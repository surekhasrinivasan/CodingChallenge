using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTechniquesBasicChallenge2
{
    /* You have two integer arrays, a and b, and an integer target value v. 
     * Determine whether there is a pair of numbers, where one number is taken from a and the 
     * other from b, that can be added together to get a sum of v. Return true if such a pair exists, 
     * otherwise return false.
     * 
     * Example
     * 
     * For a = [1, 2, 3], b = [10, 20, 30, 40], and v = 42, the output should be
     * sumOfTwo(a, b, v) = true.
     */
    class Program
    {
        public static bool sumOfTwo(int[] a,int[] b, int v)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if (a[i] + b[j] == v)
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 10, 20, 30, 40 };
            int v = 42;

            Console.WriteLine(sumOfTwo(a, b, v));
        }
    }
}
