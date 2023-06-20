using Microsoft.AspNetCore.Mvc;
using Skender.Stock.Indicators;

namespace Api;

public static class Indicators
{
    public static void Map(WebApplication app)
    {
        // Exponential Moving Average (EMA)
        app.MapPost("/ema", (
            [FromQuery(Name = "p")] int lookbackPeriods,
            [FromBody] List<EpochQuote> quotes)

            => Results.Json(quotes.GetEma(lookbackPeriods)));
    }
}
