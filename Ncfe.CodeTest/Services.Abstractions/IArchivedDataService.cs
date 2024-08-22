using Ncfe.CodeTest.Models;

namespace Ncfe.CodeTest.Services.Abstractions
{
    public interface IArchivedDataService
    {
        Learner GetArchivedLearner(int learnerId);
    }
}