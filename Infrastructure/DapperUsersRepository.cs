using BankingApi.Application;
using Dapper;
using Microsoft.Data.SqlClient;

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
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var sql = "INSERT INTO Users (UserName, UserPassword) VALUES (@UserName, @UserPassword)";
            await connection.ExecuteAsync(sql, users);
        }
    }

    public async Task UpdateUserAsync(Users users)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var sql = @"UPDATE Users SET
                            Username = @Username,
                            UserPassword = @UserPassword
                        WHERE UserId = @UserId";

            await connection.ExecuteAsync(sql, users);
        }    
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