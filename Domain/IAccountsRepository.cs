namespace BankingApi;

public interface IAccountsRepository
{
    Task AddAccountAsync(Account account);
    Task<List<Account>> FindAllAccountsAsync(int UserId);
    Task<Account?> FindAccountByIdAsync(int accountId);
}