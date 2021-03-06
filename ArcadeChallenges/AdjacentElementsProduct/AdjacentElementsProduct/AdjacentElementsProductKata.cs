﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentElementsProduct
{
    public class AdjacentElementsProductKata
    {
        public static int adjacentElementsProduct(int[] inputArray)
        {
            // Check for negative testcases
            int result = -1000;

            for(int i = 0; i < inputArray.Length-1; i++)
            {
                if(inputArray[i] * inputArray[i + 1] > result)
                {
                    result = inputArray[i] * inputArray[i + 1];
                }
            }
            return result;
        }
    }
}
