using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Skender.Stock.Indicators;

namespace Api;

public static class Indicators
{
    public static void Map(WebApplication app)
    {
        // Exponential Moving Average (EMA)
        app.MapPost("/ema",
            Results<Ok<IEnumerable<EmaResult>>, BadRequest<Error>>
            ([FromQuery] int p, [FromBody] IEnumerable<Quote> quotes) =>
            {
                try
                {
                    IEnumerable<EmaResult> r = quotes.GetEma(p);
                    return TypedResults.Ok(r);
                }
                catch (ArgumentOutOfRangeException rex)
                {
                    return TypedResults.BadRequest(new Error(rex.Message));
                }
            })
            .WithOpenApi(ops => new(ops)
            {
                Summary = "Exponential Moving Average (EMA)",
            });

        // Simple Moving Average (SMA)
        app.MapPost("/sma",
            Results<Ok<IEnumerable<SmaResult>>, BadRequest<Error>>
            ([FromQuery] int p, [FromBody] IEnumerable<Quote> quotes) =>
            {
                try
                {
                    IEnumerable<SmaResult> r = quotes.GetSma(p);
                    return TypedResults.Ok(r);
                }
                catch (ArgumentOutOfRangeException rex)
                {
                    return TypedResults.BadRequest(new Error(rex.Message));
                }
            })
            .WithOpenApi(ops => new(ops)
            {
                Summary = "Simple Moving Average (SMA)",
            });
    }
}
