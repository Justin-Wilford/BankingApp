using BankingApi.Application;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BankingApi.Infrastructure;

public sealed class DapperTransactionsRepository : ITransactionsRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperTransactionsRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }
    public async Task AddCreditAsync(Transactions transaction)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
        
            var sql = "INSERT INTO Transactions (TransactionType, Amount, AccountId, TransactionDate) VALUES ('Credit', @Amount, @AccountId, @TransactionDate);" + 
                "Update Accounts SET Balance = Balance + 50 WHERE AccountId = @AccountId;";
            await connection.ExecuteAsync(sql, transaction);
        }
    }

    public async Task AddDebitAsync(Transactions transaction)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Transactions>> FindTransactionsByAccountIdAsync(int accountId)
    {
        throw new NotImplementedException();
    }

    public async Task<Transactions> FindTransactionsByTransactionIdAsync(int transactionId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Transactions>> FindTransactionsByDateAsync(int accountId, DateTime date)
    {
        throw new NotImplementedException();
    }
}