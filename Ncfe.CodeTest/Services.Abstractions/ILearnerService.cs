using Ncfe.CodeTest.Models.Abstractions;

namespace Ncfe.CodeTest.Services.Abstractions
{
    public interface ILearnerService
    {
        ILearner GetLearner(int learnerId, bool isLearnerArchived);
    }
}