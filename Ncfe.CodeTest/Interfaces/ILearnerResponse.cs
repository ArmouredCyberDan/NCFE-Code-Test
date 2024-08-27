namespace Ncfe.CodeTest.Interfaces
{
    public interface ILearnerResponse
    {
        bool IsArchived { get; set; }
        ILearner Learner { get; set; }
    }
}