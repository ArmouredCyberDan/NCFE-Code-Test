using Ncfe.CodeTest.DataAccess.Abstractions;
using Ncfe.CodeTest.Models;
using Ncfe.CodeTest.Responses;

namespace Ncfe.CodeTest.DataAccess
{
    public class LearnerDataAccess : ILearnerDataAccess
    {
        public LearnerResponse LoadLearner(int learnerId)
        {
            // rettrieve learner from 3rd party webservice
            return new LearnerResponse()
            {
                IsArchived = false,
                Learner = new Learner()
            };
        }
    }
}
