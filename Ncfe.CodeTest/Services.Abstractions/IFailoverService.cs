using Ncfe.CodeTest.Models.Abstractions;

namespace Ncfe.CodeTest.Services.Abstractions
{
    public interface IFailoverService
    {
        bool FailOverEnabled();
        ILearner GetFailoverLearnerById(int learnerId);
    }
}