using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCartChallenge
{
    public static class OrderDelivery
    {        
        public static bool[] Delivery(int[] order, int[][] shoppers)
        {
            bool[] results = new bool[shoppers.Length];
            double order_distance = order[0];
            double order_readyTime = order[1];
            double order_waitTime = order[2];

            for (int i = 0; i < shoppers.Length; i++)
            {
                double travelTime = (order_distance + shoppers[i][0]) / shoppers[i][1] + shoppers[i][2];

                double orderTimeLimit = order_readyTime + order_waitTime;

                if ((travelTime < order_readyTime) || (travelTime > orderTimeLimit))
                {
                    results[i] = false;
                }
                else
                {
                    results[i] = true;
                }
                Console.WriteLine(travelTime);
                Console.WriteLine(orderTimeLimit);
            }
            return results;
        }
    }
}