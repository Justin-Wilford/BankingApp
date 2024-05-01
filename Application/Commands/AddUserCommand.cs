using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Commands;

public sealed class AddUserCommand : HttpEndpoint
{
    [HttpPost("Users")]
    public async Task ExecuteAsync(
        [FromServices] IUsersRepository usersRepository,
        [FromBody] Users users)
    {
        await usersRepository.AddUserAsync(users);
    }
}