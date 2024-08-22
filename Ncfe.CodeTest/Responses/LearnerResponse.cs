using Ncfe.CodeTest.Models.Abstractions;
using Ncfe.CodeTest.Responses.Abstractions;

namespace Ncfe.CodeTest.Responses
{
    public class LearnerResponse : ILearnerResponse
    {
        public bool IsArchived { get; set; }

        public ILearner Learner { get; set; }
    }
}
