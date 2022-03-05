using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Solving.Problems.Easy
{
    public static class BetweenTwoSets
    {
        public static void Execute()
        {
            Console.WriteLine("This is the Between Two Sets, Enter the required data... ");
            Console.Write("Enter the first Array elements separated by comma: ");
            List<int> a = Console.ReadLine().TrimEnd().Split(',').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Console.Write("Enter the second Array elements separated by comma: ");
            List<int> b = Console.ReadLine().TrimEnd().Split(',').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Console.WriteLine($"So, there are {getTotalX(a, b)} possible numbers.");
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            /*
             * So we have two arrays and we need to know the count of 
             * numbers that can be divided on every number in the first array 
             * and in the same time all the numbers in the second array 
             * can be devided on it    
             * So, it should be greater than or equal to maximum element in the first array
             * And, it should be less than or equal to the smallest element in the second array
            */

            //my first solution to be enhanced

            var count = 0;
            var biggestPossibleNumber = b.Min();
            var smallestPossibleNumber = a.Max();

            for (var i = smallestPossibleNumber; i <= biggestPossibleNumber; i++)
            {
                var addToCount = true;
                for (var j = 0; j < a.Count; j++)
                {
                    if (i % a[j] != 0)
                    {
                        addToCount = false;
                        j = a.Count;
                    }
                }

                if (addToCount)
                {
                    for (var k = 0; k < b.Count; k++)
                    {
                        if (b[k] % i != 0)
                        {
                            addToCount = false;
                            k = b.Count;
                        }
                    }
                }

                if (addToCount)
                {
                    count = count + 1;
                }
            }

            return count;
        }
    }
}
