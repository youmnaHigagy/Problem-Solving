using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace Problem.Solving.Data.Repositories
{
    class ProblemsRepository
    {
        public Entities.Problem[] GetProblems()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Datasource\Problems.json");
            var problems = JsonConvert.DeserializeObject<Entities.Problem[]>(File.ReadAllText(path));
            return problems;
        }
    }
}
