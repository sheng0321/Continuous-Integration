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
    public class PlatformsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PlatformsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Platforms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoritePlatform>>> GetFavoritePlatform()
        {
            return await _context.FavoritePlatform.ToListAsync();
        }

        // GET: api/Platforms/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<FavoritePlatform>> GetFavoritePlatform(Guid id)
        //{
        //    var favoritePlatform = await _context.FavoritePlatform.FindAsync(id);

        //    if (favoritePlatform == null)
        //    {
        //        return NotFound();
        //    }

        //    return favoritePlatform;
        //}

        //// PUT: api/Platforms/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFavoritePlatform(Guid id, FavoritePlatform favoritePlatform)
        //{
        //    if (id != favoritePlatform.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(favoritePlatform).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FavoritePlatformExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Platforms
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<FavoritePlatform>> PostFavoritePlatform(FavoritePlatform favoritePlatform)
        //{
        //    _context.FavoritePlatform.Add(favoritePlatform);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFavoritePlatform", new { id = favoritePlatform.Id }, favoritePlatform);
        //}

        //// DELETE: api/Platforms/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFavoritePlatform(Guid id)
        //{
        //    var favoritePlatform = await _context.FavoritePlatform.FindAsync(id);
        //    if (favoritePlatform == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.FavoritePlatform.Remove(favoritePlatform);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FavoritePlatformExists(Guid id)
        //{
        //    return _context.FavoritePlatform.Any(e => e.Id == id);
        //}
    }
}
