using Microsoft.Extensions.DependencyInjection;

namespace FalseNegativeInvestigation.Application
{
    public static class Bindings
    {
        public static IServiceCollection AddApplicationBindings(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<Processor>();

            return serviceCollection;
        }
    }
}
