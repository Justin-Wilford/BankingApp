using BankingApi.Infrastructure;

namespace BankingApi.Application;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddDapperRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAccountsRepository, DapperAccountsRepository>();
        services.AddScoped<ITransactionsRepository, DapperTransactionsRepository>();
        services.AddScoped<IUsersRepository, DapperUsersRepository>();

        return services;
    }
}