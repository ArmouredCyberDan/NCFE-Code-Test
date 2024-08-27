namespace Ncfe.CodeTest.Interfaces
{
    public interface ILearnerService
    {
        ILearner GetLearner(int learnerId, bool isLearnerArchived);
    }
}