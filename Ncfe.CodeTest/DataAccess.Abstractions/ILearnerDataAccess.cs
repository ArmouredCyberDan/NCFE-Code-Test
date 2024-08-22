using Ncfe.CodeTest.Responses;

namespace Ncfe.CodeTest.DataAccess.Abstractions
{
    public interface ILearnerDataAccess
    {
        LearnerResponse LoadLearner(int learnerId);
    }
}