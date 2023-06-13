using System.ComponentModel.DataAnnotations;

namespace Api;

public class EmaInput : IndicatorInput
{
    [Required]
    public int LookbackPeriods { get; set; }
}
