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
    public class GameReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GameReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GameReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameReview>>> GetGameReviews()
        {
            return await _context.GameReviews.ToListAsync();
        }

        // GET: api/GameReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameReview>> GetGameReview(Guid id)
        {
            var gameReview = await _context.GameReviews.FindAsync(id);

            if (gameReview == null)
            {
                return NotFound();
            }

            return gameReview;
        }

        // PUT: api/GameReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameReview(Guid id, GameReview gameReview)
        {
            if (id != gameReview.ReviewID)
            {
                return BadRequest();
            }

            _context.Entry(gameReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameReviewExists(id))
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

        // POST: api/GameReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // updated by lxd
        [HttpPost]
        public async Task<ActionResult<GameReview>> PostGameReview(GameReview gameReview)
        {
            // Check if the user has already submitted a review for the game
            var existingReview = await _context.GameReviews
                .FirstOrDefaultAsync(r => r.MemberID == gameReview.MemberID && r.GameID == gameReview.GameID);

            if (existingReview != null)
            {
                // Return a bad request response if a review already exists for this user and game
                return BadRequest("You have already submitted a review for this game.");
            }

            // If no existing review, proceed to add the new review
            _context.GameReviews.Add(gameReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameReview", new { id = gameReview.ReviewID }, gameReview);
        }

        // DELETE: api/GameReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameReview(Guid id)
        {
            var gameReview = await _context.GameReviews.FindAsync(id);
            if (gameReview == null)
            {
                return NotFound();
            }

            _context.GameReviews.Remove(gameReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameReviewExists(Guid id)
        {
            return _context.GameReviews.Any(e => e.ReviewID == id);
        }
    }
}
