using System.ComponentModel.DataAnnotations;

namespace prn_odata.Models;

public class CovidCase
{
    [Key]
    public int Id { get; set; }
    public string? ProvinceState { get; set; }
    public string CountryRegion { get; set; } = string.Empty;
    public double? Lat { get; set; }
    public double? Long { get; set; }
    public DateTime Date { get; set; }
    public int Confirmed { get; set; }
    public int Deaths { get; set; }
    public int Recovered { get; set; }
    public int? Active { get; set; }
}