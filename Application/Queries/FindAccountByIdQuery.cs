using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindAccountByIdQuery : HttpEndpoint
{
    [HttpGet("account/{accountId}")]
    public async Task<Account?> ExecuteAsync(
        [FromServices] IAccountsRepository accountsRepository,
        [FromRoute] int accountId)
    {
        var account = accountsRepository.FindAccountByIdAsync(accountId);

        return await account;
    }
}