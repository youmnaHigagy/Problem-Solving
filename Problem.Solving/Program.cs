using Problem.Solving.Problems.Easy;
using System;

namespace Problem.Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            var terminate = false;

            Console.WriteLine("Hello Problems!");
            Console.WriteLine("For Number Line Jumps choose 1");
            Console.WriteLine("For Between Two Sets choose 2");

            while (!terminate)
            {
                Console.Write("\n\nChoose a problem to be Executed: ");
                var game = Console.ReadLine();
                switch (game)
                {
                    case "1":
                        NumberLineJumps.Execute();
                        break;
                    case "2":
                        BetweenTwoSets.Execute();
                        break;
                }

                Console.Write("To terminate choose 0, or press any key to repeat: ");
                terminate = Console.ReadLine() == "0";
            }

        }
    }
}
