using mtgv2_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using mtgv2_api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add Entity Framework with PostgreSQL database
builder.Services.AddDbContext<MtgContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure OData EDM model
builder.Services.AddControllers()
    .AddOData(options => options
        .Select()
        .Filter()
        .OrderBy()
        .Expand()
        .Count()
        .SetMaxTop(100)
        .AddRouteComponents("odata", GetEdmModel()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Only use HTTPS redirection in production
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

// OData EDM model configuration
static IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    
    // Configure the Card entity with explicit key
    var cardEntity = builder.EntitySet<Card>("Cards").EntityType;
    cardEntity.HasKey(c => c.oracle_id);
    
    // Configure the CardCombo entity with explicit key (variant_id is an integer)
    var cardComboEntity = builder.EntitySet<CardCombo>("card_combos").EntityType;
    cardComboEntity.HasKey(c => c.variant_id);
    
    return builder.GetEdmModel();
}
