using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalCompanyBotStrategy
{
    /* Each CodeSignal Company Bot is trained by engineers from that specific company. 
     * The way it works is that a representative group of engineers from each company is identified as 
     * trainers before the bot goes live, and they CodeFight against the bot during a training phase. 
     * The current training algorithm is definitely more complex, but let's assume it works this way:
     * 
     * For each trainer we collect two pieces of information per task [answerTime, correctness], where 
     * correctness is 1 if the answer was correct, -1 if the answer was wrong, and 0 if no answer was given. 
     * In this case, the bot's correct answer time for a given task would be the average of the answer times 
     * from the trainers who answered correctly. Given all of the training information for a specific task, calculate the bot's answer time.
     * 
     * Example
     * For trainingData = [[3, 1],
                [6, 1],
                [4, 1],
                [5, 1]]
                the output should be companyBotStrategy(trainingData) = 4.5.
                All four trainers have solved the task correctly, so the answer is (3 + 6 + 4 + 5) / 4 = 4.5.
     * For trainingData = [[4, 1],
                [4, -1],
                [0, 0],
                [6, 1]]
                the output should be companyBotStrategy(trainingData) = 5.0.
                Only the 1st and the 4th trainers (1-based) submitted correct solutions, so the answer is (4 + 6) / 2 = 5.0.
                For trainingData = [[4, -1],
                [0, 0],
                [5, -1]]
                the output should be companyBotStrategy(trainingData) = 0.0. No correct answers were given for the task.
     */
    class Program
    {
        public static double CompanyBotStrategy(int[][] trainingData)
        {
            double result = 0;
            double sum = 0;

            for (int i = 0; i < trainingData.Length; i++)
            {
                if (trainingData[i][1] == 1)
                {
                    result++;
                    sum += trainingData[i][0];
                }
            }
            if (result == 0)
            {
                result = 0;
            }
            else
            {
                result = sum / result;
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Testcases
            int[][] trainingData = {
                new int[]{ 3, 1 },
                new int[]{ 6, 1 },
                new int[]{ 4, 1 },
                new int[]{ 5, 1 } };            

            double result = CompanyBotStrategy(trainingData);
            Console.WriteLine(result);

            int[][] trainingData2 = {
                new int[] {4, 1 },
                new int[] {4, -1 },
                new int[] {0, 0 },
                new int[] {6, 1 } };

            double result2 = CompanyBotStrategy(trainingData2);
            Console.WriteLine(result2);

            int[][] trainingData3 = {
                new int[]{4, -1 },
                new int[]{0, 0 },
                new int[]{5, -1 } };
            
            double result3 = CompanyBotStrategy(trainingData3);
            Console.WriteLine(result3);
        }
    }
}