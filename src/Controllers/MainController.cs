using Microsoft.AspNetCore.Mvc;
using Skender.Stock.Indicators;

namespace Api;

[ApiController]
[Route("")]
public class MainController : ControllerBase
{
    //////////////////////////////////////////
    // INDICATORS (sorted alphabetically)

    [HttpPost("ema")]
    public ActionResult<IEnumerable<EmaResult>> PostEma(EmaInput input)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            IEnumerable<EmaResult> results = input.Quotes
                .GetEma(input.LookbackPeriods);

            return Ok(results);
        }
        catch (ArgumentOutOfRangeException rex)
        {
            return BadRequest(rex.Message);
        }
    }
}
