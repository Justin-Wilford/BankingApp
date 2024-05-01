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
            await connection.ExecuteAsync(sql, account);
        }
    }

    public async Task<List<Accounts>> FindAllAccountsAsync(int userId)
    {
        await using var connection = new SqlConnection(_databaseOptions.ConnectionString);
        
        await connection.OpenAsync();

        var sql = await connection.QueryAsync<Accounts>("SELECT * FROM Accounts Where UserId = @UserId", new {UserId = userId});

        return sql.ToList();
    }

    public async Task<Accounts?> FindAccountByIdAsync(int accountId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var sql = await connection.QuerySingleAsync<Accounts>("SELECT * FROM Accounts WHERE AccountId = @AccountId", new {AccountId = accountId});

            return sql;
        }  
    }
}