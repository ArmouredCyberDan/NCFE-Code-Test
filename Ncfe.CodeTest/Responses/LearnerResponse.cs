using Ncfe.CodeTest.Interfaces;

namespace Ncfe.CodeTest.Responses
{
    public class LearnerResponse : ILearnerResponse
    {
        public bool IsArchived { get; set; }

        public ILearner Learner { get; set; }
    }
}
