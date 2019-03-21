using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimatorChallenge
{
    public class UberFareEstimator
    {
        public int ride_time;
        public int ride_distance;
        public double cost_per_minute;
        public double cost_per_mile;

        public UberFareEstimator()
        {
        }

        public void setRideTime(int rideTime)
        {
            ride_time = rideTime;
        }

        public void setRideDistance(int rideDist)
        {
            ride_distance = rideDist;
        }

        public void setCostPerMin(double costPerMin)
        {
            cost_per_minute = costPerMin;
        }

        public void setCostPerMile(double costPerMile)
        {
            cost_per_mile = costPerMile;
        }

        public double fareEstimator()
        {
            double result = ride_time * cost_per_minute + ride_distance * cost_per_mile;            
            return result = Math.Round(result, 2);           
        }
    }
}

        //public static double[] fareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile)
        //{
        //    double[] results = new double[cost_per_minute.Length];

        //    for (int i = 0; i < cost_per_minute.Length; i++)
        //    {
        //        results[i] = ride_time * cost_per_minute[i] + ride_distance * cost_per_mile[i];
        //        results[i] = Math.Round(results[i], 2);

        //        Console.Write(Math.Round(results[i], 2) + " ");
        //    }
        //    return results;
        //}
