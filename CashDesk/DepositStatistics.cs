namespace CashDesk
{
    class DepositStatistics : IDepositStatistics
    {
        public int DepositStatisticsId { get; set; }

        public IMember Member { get; set; }

        public int Year { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
