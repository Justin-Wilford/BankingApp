namespace BankingApi;

public interface IAccountsRepository
{
    Task AddAccountAsync(Accounts account);
    Task<List<Accounts>> FindAllAccountsAsync();
    Task<Accounts?> FindAccountByIdAsync(int accountId);
}