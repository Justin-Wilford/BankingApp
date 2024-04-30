using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Commands;

public sealed class AddAccountCommand : HttpEndpoint
{
    [HttpPost("Account")]
    public async Task ExecuteAsync(
        [FromServices] IAccountsRepository accountsRepository,
        [FromBody] Accounts accounts)
    {
        await accountsRepository.AddAccountAsync(accounts);
    }
}