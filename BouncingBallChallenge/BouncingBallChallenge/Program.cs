using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBallChallenge
{
    class Program
    {
        /* A child is playing with a ball on the nth floor of a tall building. The height of this floor, is h. For example 3 meters
         * He drops the ball out of the window. The ball bounces at a rate of br of it’s height for example a rate of 
         * two-thirds of its height would be a bounce rate of 0.66.
         * His mother looks out of a window win meters from the ground. Example: 1.5 meters
         * How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the floor: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the ball bounce rate: ");
            double br = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the window height from the ground: ");
            double w = Convert.ToDouble(Console.ReadLine());

            BouncingBall b = new BouncingBall();

            Console.WriteLine(b.bouncingBall(h, br, w));            
        }
    }
}
