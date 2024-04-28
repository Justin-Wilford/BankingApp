using BankingApi.Application;

namespace BankingApi.Infrastructure;

public sealed class DapperUsersRepository : IUsersRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperUsersRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task AddUserAsync(Users users)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateUserAsync(Users users)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Users>> FindAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Users?> FindUserByIdAsync(int userId)
    {
        throw new NotImplementedException();
    }
}