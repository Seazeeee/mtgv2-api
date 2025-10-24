using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using mtgv2_api.Models;
using mtgv2_api.Data;
using Microsoft.EntityFrameworkCore;

namespace mtgv2_api.Controllers
{
    [ApiController]
    [Route("odata")]
    public class CardsController : ODataController
    {
        private readonly MtgContext _context;
        
        public CardsController(MtgContext context)
        {
            _context = context;
        }
        
        [EnableQuery]
        [HttpGet("Cards")]
        public IQueryable<Card> Get()
        {
            // OData automatically handles $filter, $select, etc.
            return _context.Cards;
        }
        
        [HttpGet("Cards/test-connection")]
        public async Task<IActionResult> TestConnection()
        {
            try
            {
                // Test if we can connect to the database
                var canConnect = await _context.Database.CanConnectAsync();
                
                if (canConnect)
                {
                    // Try to get the count of cards (this will fail if table doesn't exist, but connection works)
                    var cardCount = await _context.Cards.CountAsync();
                    return Ok(new { 
                        message = "Database connection successful!", 
                        cardCount = cardCount,
                        timestamp = DateTime.UtcNow 
                    });
                }
                else
                {
                    return BadRequest("Cannot connect to database");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Database connection failed: {ex.Message}");
            }
        }
    }
}