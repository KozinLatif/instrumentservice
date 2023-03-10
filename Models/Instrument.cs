using System.ComponentModel.DataAnnotations;

namespace InstrumentService.Models;

public class Instrument
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string? Isin { get; set; }
    [Required]
    public string? Name { get; set; }
}
