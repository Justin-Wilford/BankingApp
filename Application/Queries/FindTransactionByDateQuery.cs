using Microsoft.AspNetCore.Mvc;

namespace BankingApi.Application.Queries;

public sealed class FindTransactionsByDateQuery : HttpEndpoint
{
    [HttpGet("HeartRate")]
    public async Task<List<Transactions>> ExecuteAsync(
        [FromQuery] DateTime TransactionDate,
        [FromQuery] int AccountId,
        [FromServices] ITransactionsRepository transactionsRepository)
    {
        var transactions = transactionsRepository.FindTransactionsByDateAsync(AccountId, TransactionDate);

        return await transactions;
    }
}