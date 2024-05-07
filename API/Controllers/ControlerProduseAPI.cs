using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.Entitati
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControlerProduseAPI : ControllerBase
    {
        private readonly MagazinContext context;

        public ControlerProduseAPI(MagazinContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produs>>> ObtineProduse()
        {
            return await context.Produs.ToListAsync();   
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produs>> ObtineProdus(int id)
        {
            var produs = await context.Produs.FirstOrDefaultAsync(p => p.Id == id);

            if (produs == null)
            {
                return NotFound();
            }

            return Ok(produs);
        }
    }
}