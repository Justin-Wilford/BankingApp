using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindUserByIdQuery : HttpEndpoint
{
    [HttpGet("users/{userId}")]
    public async Task<User> ExecuteAsync(
        [FromServices] IUsersRepository usersRepository,
        [FromRoute] int userId)
    {
        var user = usersRepository.FindUserByIdAsync(userId);

        return await user;
    }
}