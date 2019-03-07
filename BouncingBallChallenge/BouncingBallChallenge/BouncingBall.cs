using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBallChallenge
{
    public class BouncingBall
    {
        /*Take note of the following conditions:

        ** Float parameter "h" in meters must be greater than 0**
        ** Float parameter “br" must be greater than 0 and less than 1**
        ** Float parameter “win" must be less than h.**
        * If all three conditions above are fulfilled, return a positive integer of the number of times the mother sees the ball pass her window, otherwise return -1.
        * 
        * Note: The ball can only be seen if the height of the rebounding ball is stricty greater than the win parameter. IE: rebounding h > win

         */

        private bool isValidExperiment(double height, double bounceRate)
        {
            return height > 0 && bounceRate > 0 && bounceRate < 1;

        }
        public int bouncingBall(double height, double bounceRate, double window)
        {
            // ballSeen is -1 if any of the inputs are not valid 
            int ballSeen = -1;

            if(isValidExperiment(height, bounceRate))
            {
                while(height > window)
                {
                    height *= bounceRate;
                    ballSeen +=2;
                }
            }            
            return ballSeen;
        }
    }
}
