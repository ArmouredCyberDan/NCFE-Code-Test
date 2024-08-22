using Ncfe.CodeTest.Models.Abstractions;

namespace Ncfe.CodeTest.Models
{
    public class Learner : ILearner
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
