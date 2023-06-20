using Skender.Stock.Indicators;

namespace Api;

public class EpochQuote : IQuote, ISeries
{
    public long Timestamp { get; set; }
    public DateTime Date => DateTime.UnixEpoch.AddSeconds(Timestamp);
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
    public decimal Volume { get; set; }
}
