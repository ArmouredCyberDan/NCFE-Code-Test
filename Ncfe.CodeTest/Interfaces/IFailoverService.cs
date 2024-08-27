namespace Ncfe.CodeTest.Interfaces
{
    public interface IFailoverService
    {
        bool FailOverEnabled();
        ILearner GetFailoverLearnerById(int learnerId);
    }
}