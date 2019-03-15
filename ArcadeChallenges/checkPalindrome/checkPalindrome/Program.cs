using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPalindrome
{
    /* Given the string, check if it is a palindrome.
     * 
     * Example :
     * For inputString = "aabaa", the output should be
     * checkPalindrome(inputString) = true;
     * For inputString = "abac", the output should be
     * checkPalindrome(inputString) = false;
     * For inputString = "a", the output should be
     * checkPalindrome(inputString) = true.
     * 
     */
    class Program
    {
        public static bool CheckPalindrome(string inputString)
        {
            var strArray = inputString.ToCharArray();
            Array.Reverse(strArray);
            if (inputString.Equals(new string(strArray)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckPalindrome("aabaa"));
            Console.WriteLine(CheckPalindrome("abac"));
            Console.WriteLine(CheckPalindrome("kayak"));
            Console.WriteLine(CheckPalindrome("a"));
            Console.WriteLine(CheckPalindrome("abacab"));
        }
    }
}
