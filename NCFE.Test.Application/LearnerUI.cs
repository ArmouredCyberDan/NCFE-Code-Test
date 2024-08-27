﻿using Ncfe.CodeTest.Interfaces;

namespace NCFE.Test.Application
{
    public class LearnerUI
    {
        private readonly ILearnerService _learnerService;

        public LearnerUI(ILearnerService learnerService)
        {
            _learnerService = learnerService;
        }

        public ILearner GetLearner()
        {
            ILearner learner = null;
            learner = _learnerService.GetLearner(1, false);

            return learner;
        }
    }
}
