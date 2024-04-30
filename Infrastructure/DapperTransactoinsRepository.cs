using BankingApi.Application;

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
        throw new NotImplementedException();
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