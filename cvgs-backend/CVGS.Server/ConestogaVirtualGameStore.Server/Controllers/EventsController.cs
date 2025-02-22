using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Data.Models;
using Microsoft.AspNetCore.Authorization;
using ConestogaVirtualGameStore.Server.Data.Enums;

namespace ConestogaVirtualGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CvgsEvent>>> GetUpcomingEvent()
        {
            return await _context.CvgsEvents.Where(x=>x.EventDateTime>= DateTime.Now && x.IsDeleted==false).ToListAsync();
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CvgsEvent>> GetCvgsEvent(Guid id)
        {
            var cvgsEvent = await _context.CvgsEvents.FindAsync(id);

            if (cvgsEvent == null)
            {
                return NotFound();
            }

            return cvgsEvent;
        }

        // PUT: api/Events/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<CvgsEvent>> PutCvgsEvent(Guid id, CvgsEvent cvgsEvent)
        {
            if (id != cvgsEvent.Id)
            {
                return BadRequest();
            }

            // Set the UpdateTime to the current time by lxd
            cvgsEvent.UpdateTime = DateTime.Now;

            _context.Entry(cvgsEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CvgsEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return cvgsEvent;
        }

        // POST: api/Events
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CvgsEvent>> PostCvgsEvent(CvgsEvent cvgsEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Some field missed");
            }

            // Set the UpdateTime to the current time when adding a new event by lxd
            cvgsEvent.UpdateTime = DateTime.Now;

            _context.CvgsEvents.Add(cvgsEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCvgsEvent", new { id = cvgsEvent.Id }, cvgsEvent);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCvgsEvent(Guid id)
        {
            var cvgsEvent = await _context.CvgsEvents.FindAsync(id);
            if (cvgsEvent == null)
            {
                return NotFound();
            }
            cvgsEvent.IsDeleted = true;
            _context.CvgsEvents.Update(cvgsEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CvgsEventExists(Guid id)
        {
            return _context.CvgsEvents.Any(e => e.Id == id);
        }
    }
}
