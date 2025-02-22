using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Data.Models;

namespace ConestogaVirtualGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventRegistersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventRegistersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EventRegisters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventRegister>>> GetEventRegister()
        {
            return await _context.EventRegisters.ToListAsync();
        }

        // GET: api/EventRegisters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventRegister>> GetEventRegister(Guid id)
        {
            var eventRegister = await _context.EventRegisters.FindAsync(id);

            if (eventRegister == null)
            {
                return NotFound();
            }

            return eventRegister;
        }

        // PUT: api/EventRegisters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventRegister(Guid id, EventRegister eventRegister)
        {
            if (id != eventRegister.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventRegister).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventRegisterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EventRegisters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventRegister>> PostEventRegister(EventRegister eventRegister)
        {

            _context.EventRegisters.Add(eventRegister);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventRegister", new { id = eventRegister.Id }, eventRegister);
        }

        // DELETE: api/EventRegisters/5
        // Updated by lxd
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventRegister(Guid id)
        {
            var eventRegister = _context.EventRegisters.FirstOrDefault(p => p.Id == id);
            if (eventRegister == null)
            {
                return NotFound();
            }

            _context.EventRegisters.Remove(eventRegister);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventRegisterExists(Guid id)
        {
            return _context.EventRegisters.Any(e => e.Id == id);
        }
    }
}
