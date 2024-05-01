using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Commands;

public sealed class UpdateUserCommand : HttpEndpoint
{
    [HttpPut("users")]
    public async Task ExecuteAsync(
        [FromServices] IUsersRepository userRepository,
        [FromBody] Users users)
    {
        await userRepository.UpdateUserAsync(users);
    }
}