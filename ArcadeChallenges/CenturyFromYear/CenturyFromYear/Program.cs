using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyFromYear
{
    /* Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, 
     * the second - from the year 101 up to and including the year 200, etc.
     * Example
     * For year = 1905, the output should be
     * centuryFromYear(year) = 20;
     * For year = 1700, the output should be
     * centuryFromYear(year) = 17.
     */
    class Program
    {
        public static int CenturyFromYear(int year)
        {

        }

            static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            var result = CenturyFromYear(year);
            Console.WriteLine(result);
        }
    }
}
