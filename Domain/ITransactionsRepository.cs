namespace BankingApi;

public interface ITransactionsRepository
{
    Task AddTransactionsAsync(Transactions transaction);
    Task<List<Transactions>> FindTransactionsByAccountIdAsync(int accountId);
    Task<Transactions> FindTransactionsByTransactionIdAsync(int transactionId);
    Task<List<Transactions>> FindTransactionsByDateAsync(int accountId, DateTime date);
}