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
        [EnableQuery]
        [HttpGet("card_combos")]
        public IQueryable<CardCombo> GetCardCombos()
        {
            return _context.CardCombos;
        }
    }
}