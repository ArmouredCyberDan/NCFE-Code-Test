using Ncfe.CodeTest.Interfaces;

// I am using contracts above by having interfaces in their own namespace (these could be their own projects depending on the structure of the actual program), this provides flexibility as the actual implemented classes
// Can be changed out and as long as they implement these interfaces then this service doesn't need to change. This is especially powerful when changing the way data access is performed (swapping between SQL / No sql etc.)
// If i could change the the signatures in the restricted classes in this challenge then I would pass around the ILearner class only in case we want to change how this is implemented. Once the app is built around contracts,
// It becomes much easier to swap things around.
namespace Ncfe.CodeTest.Services
{
    public class LearnerService : ILearnerService
    {
        private readonly IArchivedDataService _archivedDataService;
        private readonly IFailoverService _failoverService;
        private readonly ILearnerRepository _learnerRespository;

        public LearnerService(IArchivedDataService archivedDataService, IFailoverService failoverService, ILearnerRepository learnerRepository)
        {
            _archivedDataService = archivedDataService;
            _failoverService = failoverService;
            _learnerRespository = learnerRepository;
        }
        
        // I moved out the responsibilities for different outcomes to their respective services so this method just needs to direct the users inputs to the right service or its own new repo.
        // I created a Learner Repo as the flow should be Service > Repo > Data Access in my experience.
        public ILearner GetLearner(int learnerId, bool isLearnerArchived)
        {
            if (isLearnerArchived)
            {
                return _archivedDataService.GetArchivedLearner(learnerId);
            }

            if (_failoverService.FailOverEnabled())
            {
                return _failoverService.GetFailoverLearnerById(learnerId);
            }

            ILearnerResponse learnerResponse = _learnerRespository.GetLearnerResponse(learnerId);

            if (learnerResponse.IsArchived)
            {
                return _archivedDataService.GetArchivedLearner(learnerId);
            }

            return learnerResponse.Learner;
        }
    }
}
