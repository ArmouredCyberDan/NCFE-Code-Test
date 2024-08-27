using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ncfe.CodeTest;
using Ncfe.CodeTest.Interfaces;
using NCFE.Test.Application.Interfaces;

namespace NCFE.Test.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddComponents();
            builder.Services.AddSingleton<ILearnerUI, LearnerUI>();
            using IHost host = builder.Build();

            ILearnerUI learnerUI = host.Services.GetRequiredService<ILearnerUI>();
            ILearner learner = learnerUI.GetLearner();
        }
    }
}
