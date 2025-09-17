using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using prn_odata.Models;

namespace prn_odata.Controllers;

[Route("odata/[controller]")]
public class CovidCaseController : ControllerBase
{
    private readonly CovidDbContext _context;
    public CovidCaseController(CovidDbContext context)
    {
        _context = context;
    }

    [EnableQuery]
    [HttpGet]   
    public IQueryable<CovidCase> Get()
    {
        return _context.CovidCase;
    }
}