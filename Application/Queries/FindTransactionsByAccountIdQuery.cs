using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindTransactionsByAccountIdQuery : HttpEndpoint
{
    [HttpGet("transaction/{accountId}")]
    public async Task<List<Transactions>> ExecuteAsync(
        [FromServices] ITransactionsRepository transactionsRepository,
        [FromRoute] int accountId)
    {
        var transactions = transactionsRepository.FindTransactionsByAccountIdAsync(accountId);

        return await transactions;
    }
}