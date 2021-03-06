﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTechniquesBasicChallenge1
{
    /*  Given an array of integers, write a function that determines whether the array 
     *  contains any duplicates. Your function should return true if any element appears 
     *  at least twice in the array, and it should return false if every element is distinct.
     *  
     *  Example
     *  
     *  For a = [1, 2, 3, 1], the output should be containsDuplicates(a) = true.
     *  There are two 1s in the given array.
     *  
     *  For a = [3, 1], the output should be containsDuplicates(a) = false.
     *  The given array contains no duplicates.
     * 
     */
    class Program
    {
        public static bool containsDuplicates(int[] a)
        {
            Array.Sort(a);

            for(int i = 0; i < a.Length - 1; i++)
            {
                if(a[i] == a[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4 };
            int[] inputArr2 = { 1, 2, 3, 4, 3, 5, 4 };
            Console.WriteLine("The input array contains Duplicates: {0}", containsDuplicates(inputArray));
            Console.WriteLine("The input array contains Duplicates: {0}", containsDuplicates(inputArr2));
        }
    }
}
