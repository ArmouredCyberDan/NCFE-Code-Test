using Ncfe.CodeTest.Interfaces;

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
