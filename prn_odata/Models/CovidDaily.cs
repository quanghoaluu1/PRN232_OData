using System.ComponentModel.DataAnnotations;

namespace prn_odata.Models;

public class CovidDaily
{
    [Key]
    public int Id { get; set; }
    public string? ProvinceState { get; set; }
    public string CountryRegion { get; set; } = string.Empty;
    public double? Lat { get; set; }
    public double? Long { get; set; }
    public DateTime Date { get; set; }
    public DateTime LastUpdate { get; set; }
    public double? Fips { get; set; }
    public double? IncidentRate { get; set; }
    public double? TotalTestResult { get; set; }
    public string? PeopleHospitalized { get; set; }
    public double? CaseFatalityRatio { get; set; }
    public double Uid { get; set; }
    public string Iso3 { get; set; } = string.Empty;
    public double? TestingRate { get; set; }
    public string? HospitalizationRate { get; set; }
    public string? PeopleTested { get; set; }
    public string? MortalityRate { get; set; }
}