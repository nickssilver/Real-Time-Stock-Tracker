namespace RealTimeStockTracker.Models
{
    public class StockData
    {
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal MovingAverage { get; set; }
        public decimal RSI { get; set; }
        public string NewsHeadline { get; set; }
    }
}
