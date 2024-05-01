using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Commands;

public sealed class AddDebitCommand : HttpEndpoint
{
    [HttpPost("Transaction/Debit")]
    public async Task ExecuteAsync(
        [FromServices] ITransactionsRepository transactionsRepository,
        [FromBody] Transactions transactions)
    {
        await transactionsRepository.AddDebitAsync(transactions);
    }
}