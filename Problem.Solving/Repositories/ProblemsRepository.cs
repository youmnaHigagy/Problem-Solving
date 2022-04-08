using Newtonsoft.Json;
using ProblemSolving.Entities;
using System.IO;
using System.Reflection;

namespace ProblemSolving.Repositories
{
    class ProblemsRepository
    {
        public Problem[] GetProblems()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Datasource\Problems.json");
            var problems = JsonConvert.DeserializeObject<Problem[]>(File.ReadAllText(path));
            return problems;
        }
    }
}
