using Ncfe.CodeTest.Responses;

namespace Ncfe.CodeTest.Interfaces
{
    public interface ILearnerDataAccess
    {
        LearnerResponse LoadLearner(int learnerId);
    }
}