namespace Ncfe.CodeTest.Interfaces
{
    public interface ILearnerRepository
    {
        ILearnerResponse GetLearnerResponse(int learnerId);
    }
}