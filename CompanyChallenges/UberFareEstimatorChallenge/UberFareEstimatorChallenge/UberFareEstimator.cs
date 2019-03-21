using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimatorChallenge
{
    public static class UberFareEstimator
    {
        public static double[] fareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile)
        {
            double[] results = new double[cost_per_minute.Length];

            for (int i = 0; i < cost_per_minute.Length; i++)
            {
                results[i] = ride_time * cost_per_minute[i] + ride_distance * cost_per_mile[i];
                results[i] = Math.Round(results[i], 2);

                Console.Write(Math.Round(results[i], 2) + " ");
            }
            return results;
        }
    }
}
