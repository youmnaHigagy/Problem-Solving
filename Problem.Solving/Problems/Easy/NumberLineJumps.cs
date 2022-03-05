using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Solving.Problems.Easy
{
    public static class NumberLineJumps
    {

        public static void Execute()
        {
            Console.WriteLine("This is the Number Line Jumps, Enter the required data... ");
            Console.Write("Enter the first Kangaroo initial position: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the first Kangaroo velocity: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Kangaroo initial position: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Kangaroo velocity: ");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write($"Will they meet? well,... ");
            Console.WriteLine(kangaroo(x1, v1, x2, v2));
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            /* Check if they are at the same point every jump
             * That means check if x1+v1*jumps =x2+v2*jumps
             * If matches print YES
             * Once the one with higher velocity exceeds the one with 
             * the lower velocity then print NO as they will never meet
             * Check for special casess
             */

            var terminate = false;
            var jumps = 1;
            var result = "NO";

            while (!terminate)
            {

                if ((v1 == v2 && x1 == x2) ||
                   (x1 + (v1 * jumps) == x2 + (v2 * jumps)))
                {
                    result = "YES";
                    terminate = true;
                }

                else if ((v1 == v2 && x1 != x2) ||
                   (v1 > v2 && (x1 + (v1 * jumps) > x2 + (v2 * jumps))) ||
                   (v2 > v1 && (x2 + (v2 * jumps) > x1 + (v1 * jumps))))
                {
                    terminate = true;
                }
                else
                {
                    jumps = jumps + 1;
                }
            }

            return result;
        }
    }
}
