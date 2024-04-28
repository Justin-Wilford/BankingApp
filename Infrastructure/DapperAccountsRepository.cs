using BankingApi.Application;

namespace BankingApi.Infrastructure;

public sealed class DapperAccountsRepository : IAccountsRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperAccountsRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }
    public async Task AddAccountAsync(Accounts account)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Accounts>> FindAllAccountsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Accounts?> FindAccountByIdAsync(int accountId)
    {
        throw new NotImplementedException();
    }
}