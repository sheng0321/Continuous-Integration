using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Data.Models;
using ConestogaVirtualGameStore.Server.Data.ViewModels;

namespace ConestogaVirtualGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Games
        //updated by lxd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames([FromQuery] string name = null)
        {
            // Start with the base query for games that are not deleted
            var query = _context.Games
                .Where(x => x.IsDelete == false)
                .Include(g => g.GameReviews)
                .AsQueryable();

            // If a name query parameter is provided, filter games by the name
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(g => g.GameName.Contains(name));
            }

            // Project the results to include only the necessary fields from GameCategory
            var games = await query
                .Select(g => new
                {
                    g.Id,
                    g.GameName,
                    g.Overview,
                    g.Price,
                    g.GamesInStock,
                    g.ThumbnailPath,
                    GameCategory = new
                    {
                        g.GameCategory!.Id,
                        g.GameCategory.Name // update by lxd
                        // Add any other fields from GameCategory that you need
                    },
                    g.GameReviews
                })
                .ToListAsync();

            return Ok(games);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(Guid id)
        {
            var game = await _context.Games
                .Include(g => g.GameReviews)
                .Include(g => g.GameCategory)  // Ensure category is included
                .FirstOrDefaultAsync(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // PUT: api/Games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(Guid id, Game game)
        {
            if (id != game.Id)
            {
                return BadRequest();
            }

            var category = await _context.GameCategories.FindAsync(game.GameCategoryId);
            if (category == null)
            {
                return BadRequest("Invalid category ID");
            }

            game.GameCategory = category;

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
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

        // POST: api/Games
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(GameAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Some fields missed");
            }

            var category = await _context.GameCategories.FindAsync(model.GameCategoryId);
            if (category == null)
            {
                return BadRequest("Invalid category ID");
            }

            var game = new Game
            {
                GameName = model.GameName,
                Overview = model.Overview,
                Price = model.Price,
                GameCategoryId = model.GameCategoryId, // Explicitly set the foreign key updated by lxd
                GameCategory = category,
                GamesInStock = model.GamesInStock,
                ThumbnailPath = model.ThumbnailPath
            };

            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.Id }, game);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(Guid id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            game.IsDelete = true;
            game.UpdateTime = DateTime.Now;

            _context.Games.Update(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameExists(Guid id)
        {
            return _context.Games.Any(e => e.Id == id);
        }
    }

}



