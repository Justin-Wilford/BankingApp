namespace BankingApi;

public class Transactions
{
    public int TransactionId { get; set; }
    public string TransactionType { get; set; }
    public Decimal Amount { get; set; }
    public int AccountId { get; set; }
    public DateTime TransactionDate { get; set; }
}