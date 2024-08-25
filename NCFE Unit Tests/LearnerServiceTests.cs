using Ncfe.CodeTest.DataAccess;
using Ncfe.CodeTest.DataAccess.Abstractions;
using Ncfe.CodeTest.Models;
using Ncfe.CodeTest.Models.Abstractions;
using Ncfe.CodeTest.Repositories;
using Ncfe.CodeTest.Repositories.Abstractions;
using Ncfe.CodeTest.Services;
using Ncfe.CodeTest.Services.Abstractions;

namespace NCFE_Unit_Tests
{
    [TestClass]
    public class LearnerServiceTests
    {
        ILearnerDataAccess _learnerDataAccess;
        IFailoverRepository _failoverRepository;
        ILearnerRepository _learnerRepository;
        IArchivedDataService _archivedDataService;
        IFailoverService _failoverService;
        ILearnerService _learnerService;

        public LearnerServiceTests()
        {
            _learnerDataAccess = new LearnerDataAccess();
            _failoverRepository = new FailoverRepository();
            _learnerRepository = new LearnerRepository(_learnerDataAccess);
            _archivedDataService = new ArchivedDataService();
            _failoverService = new FailoverService(_failoverRepository);
            _learnerService = new LearnerService(_archivedDataService, _failoverService, _learnerRepository);
        }

        // Test learnerId and isArchived
        [TestMethod]
        public void GetLearner_WithIsLearnerArchivedTrue_ReturnsLearner()
        {
            // Arrange
            int userId = 1;
            bool isLearnerArchived = true;

            // Act
            ILearner learner = _learnerService.GetLearner(userId, isLearnerArchived);

            // Assert
            Assert.IsInstanceOfType(learner, typeof(Learner));
        }

        // Test learnerId and !isArchived
        [TestMethod]
        public void GetLearner_WithIsLearnerArchivedFalse_ReturnsLearner()
        {
            // Arrange
            int userId = 1;
            bool isLearnerArchived = false;

            // Act
            ILearner learner = _learnerService.GetLearner(userId, isLearnerArchived);

            // Assert
            Assert.IsInstanceOfType(learner, typeof(ILearner));
        }
    }
}