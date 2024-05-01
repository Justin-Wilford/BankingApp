using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindAllAccountsAsync : HttpEndpoint
{
    [HttpGet("accounts/{userId}")]
    public async Task<List<Accounts>> ExecuteAsync(
        [FromServices] IAccountsRepository accountsRepository,
        [FromRoute] int userId)
    {
        var account = accountsRepository.FindAllAccountsAsync(userId);

        return await account;
    }
}