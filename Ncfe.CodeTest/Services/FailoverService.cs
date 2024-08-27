using Ncfe.CodeTest.DataAccess;
using System.Configuration;
using System;
using Ncfe.CodeTest.Interfaces;

namespace Ncfe.CodeTest.Services
{
    public class FailoverService : IFailoverService
    {
        private const string FailoverEnabledTrueValue = "true";
        private const string FailoverEnabledSettingsKey = "IsFailoverModeEnabled";
        private const int FailoverRequestsThreshold = 100;
        private const int MaximumHoldTimeThreshold = -10;

        private readonly IFailoverRepository _failoverRepository;

        public FailoverService(IFailoverRepository failoverRepository)
        {
            _failoverRepository = failoverRepository;
        }

        // I moved the responsibility to see if Failover should be used to this service as it makes sense that it should be handled here, I use a string.Equals and ignore case to avoid the double check for test || Test
        public bool FailOverEnabled()
        {
            var failoverSettingValue = ConfigurationManager.AppSettings[FailoverEnabledSettingsKey];
            var failedRequests = GetFailedRequests();

            if (failedRequests > FailoverRequestsThreshold && string.Equals(failoverSettingValue, FailoverEnabledTrueValue, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        // I left this as a loop, it could be made more readable if you use linq at the cost of speed. I moved it out of FailOverEnabled so it is a bit more single responsibility
        private int GetFailedRequests()
        {
            var failoverEntries = _failoverRepository.GetFailOverEntries();
            int failedRequests = 0;
            var maximumHoldTime = DateTime.Now.AddMinutes(MaximumHoldTimeThreshold);

            foreach (var failoverEntry in failoverEntries)
            {
                if (failoverEntry.DateTime > maximumHoldTime)
                {
                    failedRequests++;
                }
            }

            return failedRequests;
        }

        // I would probably move this over to have its own interface so we get a better flow but it is static
        public ILearner GetFailoverLearnerById(int learnerId)
        {
            ILearner learner = FailoverLearnerDataAccess.GetLearnerById(learnerId).Learner;
            return learner;
        }
    }
}