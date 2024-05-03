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

    public async Task AddUserAsync(User users)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var sql = "INSERT INTO Users (UserName, UserPassword) VALUES (@UserName, @UserPassword)";
            await connection.ExecuteAsync(sql, users);
        }
    }

    public async Task UpdateUserAsync(User users)
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

    public async Task<List<User>> FindAllUsersAsync()
    {
        await using var connection = new SqlConnection(_databaseOptions.ConnectionString);
        
        await connection.OpenAsync();

        var sql = await connection.QueryAsync<User>("SELECT * FROM Users");

        return sql.ToList();
    }

    public async Task<User> FindUserByIdAsync(int userId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var sql = await connection.QuerySingleAsync<User>("SELECT * FROM Users WHERE UserId = @UserId", new {UserId = userId});

            return sql;
        }
    }
}