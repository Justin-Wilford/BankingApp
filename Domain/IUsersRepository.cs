namespace BankingApi;

public interface IUsersRepository
{
    Task AddUserAsync(User users);
    Task UpdateUserAsync(User users);
    Task<List<User>> FindAllUsersAsync();
    Task<User?> FindUserByIdAsync(int userId);
}