using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Commands;

public sealed class AddCreditCommand : HttpEndpoint
{
    [HttpPost("Transaction/Credit")]
    public async Task ExecuteAsync(
        [FromServices] ITransactionsRepository transactionsRepository,
        [FromBody] Transactions transactions)
    {
        await transactionsRepository.AddCreditAsync(transactions);
    }
}