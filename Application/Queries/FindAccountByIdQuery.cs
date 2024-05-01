using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindAccountByIdAsync : HttpEndpoint
{
    [HttpGet("account/{accountId}")]
    public async Task<Accounts?> ExecuteAsync(
        [FromServices] IAccountsRepository accountsRepository,
        [FromRoute] int accountId)
    {
        var account = accountsRepository.FindAccountByIdAsync(accountId);

        return await account;
    }
}