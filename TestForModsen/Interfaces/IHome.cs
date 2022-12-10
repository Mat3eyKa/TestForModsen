using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TestForModsen.Models;

namespace TestForModsen.Interfaces
{
    public interface IHome
    {
        public IQueryable<Event> Get();
        public Task<ActionResult<Event>> Get(int id);
        public Task<ActionResult> Create(Event even);
        public Task<ActionResult> Edit(Event even);
        public Task<ActionResult> Delete(int id);
    }
}
