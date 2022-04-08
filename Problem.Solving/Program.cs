using Problem.Solving.Data.Repositories;
using Problem.Solving.Interfaces;
using Problem.Solving.Problems;
using System;
using System.Linq;

namespace Problem.Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var terminate = false;
                var problems = new ProblemsRepository().GetProblems();

                ListExistingProblemsOnScreen(problems);

                while (!terminate)
                {
                    Console.Write("\n\nChoose a problem to be Executed: ");

                    SelectAndExecuteProblem(problems);

                    Console.Write("To terminate choose 0, or press any key to repeat: ");
                    terminate = Console.ReadLine() == "0";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nObvoisly wrong input!");
            }

        }

        private static void ListExistingProblemsOnScreen(Entities.Problem[] problems)
        {
            Console.WriteLine("Hello Problems!");
            foreach (var problem in problems)
            {
                Console.WriteLine($"For {problem.Title} choose {problem.Id}");
            }
        }

        private static void SelectAndExecuteProblem(Entities.Problem[] problems)
        {
            var selectedProblemId = int.Parse(Console.ReadLine());
            var selectedProblemAlias = problems.FirstOrDefault(x => x.Id == selectedProblemId).Alias;
            var typeName = $"Problem.Solving.Problems.{selectedProblemAlias}";
            var objectType = Type.GetType(typeName);
            var selectedProblem = Activator.CreateInstance(objectType) as IProblemExecution;
            selectedProblem.Execute();
        }
    }
}
