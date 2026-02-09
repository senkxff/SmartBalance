namespace SmartBalance.Models
{
    class IncomeModel
    {
        public string? category { get; set; }
        public decimal amount { get; set; } = 0;
        public DateTime date { get; set; }
        public string? wallet { get; set; }
        public string? comment { get; set; }
    }
}
