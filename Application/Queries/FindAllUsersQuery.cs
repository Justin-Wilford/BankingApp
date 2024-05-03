using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindAllUsersQuery : HttpEndpoint
{
    [HttpGet("users")]
    public async Task<List<User>> ExecuteAsync(
        [FromServices] IUsersRepository usersRepository)
    {
        var account = usersRepository.FindAllUsersAsync();

        return await account;
    }
}