using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FalseNegativeInvestigation.Infrastructure;

public static class Bindings
{
    public static void AddInfrastructureBindings(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<DbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        serviceCollection.AddScoped<IRepository, Repository>();
    }
}
