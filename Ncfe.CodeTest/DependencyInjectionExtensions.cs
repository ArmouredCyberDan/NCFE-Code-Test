using Microsoft.Extensions.DependencyInjection;
using Ncfe.CodeTest.DataAccess;
using Ncfe.CodeTest.Models;
using Ncfe.CodeTest.Repositories;
using Ncfe.CodeTest.Responses;
using Ncfe.CodeTest.Services;
using Ncfe.CodeTest.Interfaces;

namespace Ncfe.CodeTest
{
    // This class can be used wherever you need to inject the classes and abstractions from this assembly, it makes it a bit more modular You can easily swap out
    // The actual implementation of the interfaces here
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
