namespace BankingApi;

public interface IAccountsRepository
{
    Task AddAccountAsync(Accounts account);
    Task<List<Accounts>> FindAllAccountsAsync(int UserId);
    Task<Accounts?> FindAccountByIdAsync(int accountId);
}