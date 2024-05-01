using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindTransactionsByTransactionIdQuery : HttpEndpoint
{
    [HttpGet("transactions/{transactionId}")]
    public async Task<Transactions?> ExecuteAsync(
        [FromServices] ITransactionsRepository transactionsRepository,
        [FromRoute] int transactionId)
    {
        var transaction = transactionsRepository.FindTransactionsByTransactionIdAsync(transactionId);

        return await transaction;
    }
}