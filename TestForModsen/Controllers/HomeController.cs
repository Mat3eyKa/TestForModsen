using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TestForModsen.Data;
using TestForModsen.Models;

namespace TestForModsen.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ModsenContext db;
        public HomeController(ModsenContext database) =>
            db = database;

        [HttpGet]
        public IQueryable<Event> Get()
        {
            return db.Events;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> Get(int id)
        {
            Event even = await db.Events.FindAsync(id);
            if (even is null)
                return NotFound();

            return Ok(even);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Event even)
        {
            await db.Events.AddAsync(even);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Edit(Event even)
        {
            if (even.Id is 0)
                return BadRequest();

            db.Entry(even).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Event even = await db.Events.FindAsync(id);
            if (even is null)
                return NotFound();

            return Ok();
        }
    }
}
