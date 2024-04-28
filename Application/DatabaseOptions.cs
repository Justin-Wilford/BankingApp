namespace BankingApi.Application
{
    public class DatabaseOptions
    {
        public const string SectionName = "DatabaseOptions";
        public string? ConnectionString { get; set; }
    }
}