namespace BlazorApp1.Data.Models
{
    public class OrderModel
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public string Category { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.MinValue;

        public string Description { get; set; } = string.Empty;
        public decimal? Balance { get; set;} = decimal.Zero;
        public decimal? BalancePrice { get; set; } = decimal.Zero;
        public decimal? BalanceFee { get;}
        public decimal? BalanceFeePrice { get; set; } = decimal.Zero;
        public decimal? BalanceFeeAmount { get; set; } = decimal.Zero;
    }
}
