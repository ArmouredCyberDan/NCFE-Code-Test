using Microsoft.Extensions.DependencyInjection;
using Ncfe.CodeTest.DataAccess;
using Ncfe.CodeTest.DataAccess.Abstractions;
using Ncfe.CodeTest.Models;
using Ncfe.CodeTest.Models.Abstractions;
using Ncfe.CodeTest.Repositories;
using Ncfe.CodeTest.Repositories.Abstractions;
using Ncfe.CodeTest.Responses;
using Ncfe.CodeTest.Responses.Abstractions;
using Ncfe.CodeTest.Services;
using Ncfe.CodeTest.Services.Abstractions;

namespace Ncfe.CodeTest
{
    // This class can be used wherever you need to inject the classes and abstractions from this assembly, it makes it a bit more modular
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddComponents(this IServiceCollection services)
        {
            services.AddSingleton<ILearnerDataAccess, LearnerDataAccess>();
            services.AddSingleton<IFailoverEntry, FailoverEntry>();
            services.AddSingleton<ILearner, Learner>();
            services.AddSingleton<IFailoverRepository, FailoverRepository>();
            services.AddSingleton<ILearnerRepository, LearnerRepository>();
            services.AddSingleton<ILearnerResponse, LearnerResponse>();
            services.AddSingleton<IArchivedDataService, ArchivedDataService>();
            services.AddSingleton<IFailoverService, FailoverService>();
            services.AddSingleton<ILearnerService, LearnerService>();

            return services;
        }
    }
}
