using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using prn_odata.Models;

namespace prn_odata.Controllers;

[Route("odata/[controller]")]
public class CovidDailyController : ControllerBase
{
    private readonly CovidDbContext _context;
    public CovidDailyController(CovidDbContext context)
    {
        _context = context;
    }

    [EnableQuery]
    [HttpGet]   
    public IQueryable<CovidDaily> Get()
    {
        return _context.coviddaily;
    }
}