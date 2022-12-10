using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TestForModsen.Data;
using TestForModsen.Interfaces;
using TestForModsen.Models;

namespace TestForModsen.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase, IHome
    {
        private readonly ModsenContext db;
        public HomeController(ModsenContext database) =>
            db = database;

        [HttpGet]
        public IQueryable<Event> Get() => db.Events;

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
            try
            {
                await db.Events.AddAsync(even);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Edit(Event even)
        {
            if (!await db.Events.AnyAsync(x => x.Id == even.Id))
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
