using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using ProblemSolving.Entities;

namespace ProblemSolving.Repositories
{
    class ProblemsRepository
    {
        public Problem[] GetProblems()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Datasource\Problems.json");
            var problems = JsonConvert.DeserializeObject<Problem[]>(File.ReadAllText(path));
            return problems;
        }
    }
}
