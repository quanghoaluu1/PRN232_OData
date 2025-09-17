using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;
using prn_odata;
using prn_odata.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CovidDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

ODataConventionModelBuilder odataBuilder = new();
odataBuilder.EntitySet<CovidCase>("CovidCases");

ODataConventionModelBuilder odataBuilderDaily = new();
odataBuilderDaily.EntitySet<CovidDaily>("CovidDailies");

builder.Services.AddControllers().AddOData(opt =>
{
    opt.AddRouteComponents("odata", odataBuilder.GetEdmModel())
        .Select().Filter().OrderBy().Expand().Count().SetMaxTop(1000);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();