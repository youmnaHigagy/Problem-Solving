using Problem.Solving.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem.Solving.Problems
{
    public class BreakingTheRecords: IProblemExecution
    {
        public void Execute()
        {
            Console.WriteLine("This is the Breaking The Records, Enter the required data... ");
            Console.Write("Enter the Scores elements separated by comma: ");
            List<int> scores = Console.ReadLine().TrimEnd().Split(',').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            var breaks = breakingRecords(scores);
            Console.WriteLine($"So, Maximum Record was broken {breaks[0]} times. Minimum Record was broken {breaks[1]} times.");
        }

        public int[] breakingRecords(List<int> scores)
        {
            /* 
             * Simply we have a player list of games scores
             * and we want to count and output how many times did he 
             * break his best score and how many times did he break
             * his lowest score
             */

            //my first solution to be enhanced

            var min = scores.FirstOrDefault();
            var max = min;
            var minBreaks = 0;
            var maxBreask = 0;

            for (var i = 0; i < scores.Count; i++)
            {
                var score = scores.ElementAt(i);
                if (score < min)
                {
                    min = score;
                    minBreaks = minBreaks + 1;
                }
                else if (score > max)
                {
                    max = score;
                    maxBreask = maxBreask + 1;
                }
            }

            return new int[] { maxBreask, minBreaks };

        }
    }
}
