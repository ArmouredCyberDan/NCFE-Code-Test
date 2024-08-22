using Ncfe.CodeTest.Models.Abstractions;

namespace Ncfe.CodeTest.Responses.Abstractions
{
    public interface ILearnerResponse
    {
        bool IsArchived { get; set; }
        ILearner Learner { get; set; }
    }
}