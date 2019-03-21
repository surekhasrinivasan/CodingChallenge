using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimatorChallenge
{
    /* Uber is building a Fare Estimator that can tell you how much your ride will cost before you request it. 
     * It works by passing approximated ride distance and ride time through this formula:
     * (Cost per minute) * (ride time) + (Cost per mile) * (ride distance)
     * where Cost per minute and Cost per mile depend on the car type.
     * 
     * You are one of the engineers building the Fare Estimator, so knowing cost per minute and cost per mile for each car type, as well as ride distance and ride time, return the fare estimates for all car types.
     * Example
     * For
     * ride_time = 30,
     * ride_distance = 7,
     * cost_per_minute = [0.2, 0.35, 0.4, 0.45], and
     * cost_per_mile = [1.1, 1.8, 2.3, 3.5], the output should be
     * fareEstimator(ride_time, ride_distance, cost_per_minute, cost_per_mile) = [13.7, 23.1, 28.1, 38].
     * Since:
     * 30 * 0.2 + 7 * 1.1 = 6 + 7.7 = 13.7
     * 30 * 0.35 + 7 * 1.8 = 10.5 + 12.6 = 23.1
     * 30 * 0.4 + 7 * 2.3 = 12 + 16.1 = 28.1
     * 30 * 0.45 + 7 * 3.5 = 13.5 + 24.5 = 38
     */
    class Program
    {
        static void Main(string[] args)
        {
            UberFareEstimator carType1 = new UberFareEstimator();
            UberFareEstimator carType2 = new UberFareEstimator();
            UberFareEstimator carType3 = new UberFareEstimator();
            UberFareEstimator carType4 = new UberFareEstimator();

            carType1.setRideTime(30);
            carType1.setRideDistance(7);
            carType1.setCostPerMin(0.2);
            carType1.setCostPerMile(1.1);

            carType2.setRideTime(30);
            carType2.setRideDistance(7);
            carType2.setCostPerMin(0.35);
            carType2.setCostPerMile(1.8);

            carType3.setRideTime(30);
            carType3.setRideDistance(7);
            carType3.setCostPerMin(0.4);
            carType3.setCostPerMile(2.3);

            carType4.setRideTime(30);
            carType4.setRideDistance(7);
            carType4.setCostPerMin(0.45);
            carType4.setCostPerMile(3.5);

            Console.WriteLine("The total cost for the ride is: {0}", carType1.fareEstimator());
            Console.WriteLine("The total cost for the ride is: {0}", carType2.fareEstimator());
            Console.WriteLine("The total cost for the ride is: {0}", carType3.fareEstimator());
            Console.WriteLine("The total cost for the ride is: {0}", carType4.fareEstimator());
            Console.WriteLine();

            double[] output = { carType1.fareEstimator(), carType2.fareEstimator(), carType3.fareEstimator(), carType4.fareEstimator() };

            for(int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }
            Console.WriteLine();

            
            // Method 1
            //int ride_time = 30;
            //int ride_distance = 7;
            //double[] cost_per_minute = { 0.2, 0.35, 0.4, 0.45 };
            //double[] cost_per_mile = {1.1, 1.8, 2.3, 3.5};

            //double[] output = new double[] { };
            //output = UberFareEstimator.fareEstimator(ride_time, ride_distance, cost_per_minute, cost_per_mile);
            //Console.WriteLine();
        }
    }
}
