using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ncfe.CodeTest;
using Ncfe.CodeTest.Interfaces;

namespace NCFE.Test.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddComponents();
            using IHost host = builder.Build();

            LearnerUI learnerUI = new LearnerUI(host.Services.GetRequiredService<ILearnerService>());
            ILearner learner = learnerUI.GetLearner();
        }
    }
}
