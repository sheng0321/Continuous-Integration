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
    public class GameCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GameCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GameCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameCategory>>> GetGameCategories()
        {
            return await _context.GameCategories.ToListAsync();
        }

        // GET: api/GameCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameCategory>> GetGameCategory(Guid id)
        {
            var gameCategory = await _context.GameCategories.FindAsync(id);

            if (gameCategory == null)
            {
                return NotFound();
            }

            return gameCategory;
        }

        // PUT: api/GameCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutGameCategory(Guid id, GameCategory gameCategory)
        //{
        //    if (id != gameCategory.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(gameCategory).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!GameCategoryExists(id))
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

        //// POST: api/GameCategories
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<GameCategory>> PostGameCategory(GameCategory gameCategory)
        //{
        //    _context.GameCategories.Add(gameCategory);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetGameCategory", new { id = gameCategory.Id }, gameCategory);
        //}

        //// DELETE: api/GameCategories/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteGameCategory(Guid id)
        //{
        //    var gameCategory = await _context.GameCategories.FindAsync(id);
        //    if (gameCategory == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.GameCategories.Remove(gameCategory);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool GameCategoryExists(Guid id)
        //{
        //    return _context.GameCategories.Any(e => e.Id == id);
        //}
    }
}
