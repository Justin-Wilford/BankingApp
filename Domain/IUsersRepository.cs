namespace BankingApi;

public interface IUsersRepository
{
    Task AddUserAsync(Users users);
    Task UpdateUserAsync(Users users);
    Task<List<Users>> FindAllUsersAsync();
    Task<Users?> FindUserByIdAsync(int userId);
}