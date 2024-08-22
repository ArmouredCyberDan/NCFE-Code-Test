using Ncfe.CodeTest.Responses.Abstractions;

namespace Ncfe.CodeTest.Repositories.Abstractions
{
    public interface ILearnerRepository
    {
        ILearnerResponse GetLearnerResponse(int learnerId);
    }
}