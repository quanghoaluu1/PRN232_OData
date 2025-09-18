using Microsoft.EntityFrameworkCore;
using prn_odata.Models;

namespace prn_odata;

public class CovidDbContext : DbContext
{
    public CovidDbContext(DbContextOptions<CovidDbContext> options) : base(options){}
    
    public DbSet<CovidCase> covidcase { get; set; }
    public DbSet<CovidDaily> coviddaily { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CovidCase>().HasKey(c => c.Id);
        modelBuilder.Entity<CovidDaily>().HasKey(c => c.Id);
    }
}