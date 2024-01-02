using Skender.Stock.Indicators;

namespace Api;

public class Quote : IQuote, ISeries
{
    public long DateEpoch { get; set; }
    public DateTime Date => DateTime.UnixEpoch.AddSeconds(DateEpoch);
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
    public decimal Volume { get; set; }
}

public sealed class Error(string msg)
{
    public string Message { get; } = msg;
}
