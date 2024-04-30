using BankingApi.Application;
using Dapper;
using Microsoft.Data.SqlClient;

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
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var sql = "INSERT INTO Accounts (AccountNumber, UserId, Balance) VALUES (@AccountNumber, @UserId, @Balance)";
            connection.Execute(sql, account);
        }
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