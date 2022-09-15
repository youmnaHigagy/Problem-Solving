using System;
using System.Collections.Generic;
using System.Linq;
using ProblemSolving.Interfaces;

namespace ProblemSolving.Problems
{
    public class DivisibleSumPairs : IProblemExecution
    {
        public void Execute()
        {
            Console.WriteLine("This is the Divisible Sum Pairs, Enter the required data... ");
            Console.Write("Enter the divisible by number: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the  List of numbers separated by comma: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(',').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Console.WriteLine($"So, there are {divisibleSumPairs(k, arr)} possible pairs.");
        }

        public int divisibleSumPairs(int k, List<int> arr)
        {
            /*
             * So we have an array and we want to check how many pairs the sum of which 
             * is divisible by a specific number
             * So, Just add to each item of the array one of the preceeding items and check the division
            */

            var numbers = arr.ToArray();
            var numbersLength = numbers.Length;
            var pairsCount = 0;

            for (var i = 0; i < numbersLength - 1; i++)
            {
                for (var j = i + 1; j < numbersLength; j++)
                {
                    if ((numbers[i] + numbers[j]) % k == 0)
                        pairsCount = pairsCount + 1;
                }
            }

            return pairsCount;
        }
    }
}
