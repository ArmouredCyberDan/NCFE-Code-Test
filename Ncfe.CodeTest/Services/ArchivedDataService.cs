using Ncfe.CodeTest.Models;
using Ncfe.CodeTest.Services.Abstractions;

namespace Ncfe.CodeTest.Services
{
    public class ArchivedDataService : IArchivedDataService
    {
        public Learner GetArchivedLearner(int learnerId)
        {
            // retrieve learner from archive data service
            return new Learner();
        }
    }
}