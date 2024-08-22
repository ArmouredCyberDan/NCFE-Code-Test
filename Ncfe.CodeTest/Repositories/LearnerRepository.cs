using Ncfe.CodeTest.DataAccess.Abstractions;
using Ncfe.CodeTest.Repositories.Abstractions;
using Ncfe.CodeTest.Responses.Abstractions;

namespace Ncfe.CodeTest.Repositories
{
    public class LearnerRepository : ILearnerRepository
    {
        private readonly ILearnerDataAccess _learnerDataAccess;

        public LearnerRepository(ILearnerDataAccess learnerDataAccess)
        {
            _learnerDataAccess = learnerDataAccess;
        }

        public ILearnerResponse GetLearnerResponse(int learnerId)
        {
            return _learnerDataAccess.LoadLearner(learnerId);
        }
    }
}
