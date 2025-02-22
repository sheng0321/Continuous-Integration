using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Data.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ConestogaVirtualGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberPreferencesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MemberPreferencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MemberPreferences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberPreference>>> GetMemberPreferences()
        {
            return await _context.MemberPreference
                .Include(mp => mp.FavoritePlatform)        // Eagerly load Platform
                .Include(mp => mp.FavoriteGameCategory)    // Eagerly load GameCategory
                .Include(mp => mp.LanguagePreference)      // Eagerly load Language
                .ToListAsync();
        }

        // GET: api/MemberPreferences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberPreference>> GetMemberPreference(Guid id)
        {
            var memberPreference = await _context.MemberPreference
                .Include(mp => mp.FavoritePlatform)        // Eagerly load Platform
                .Include(mp => mp.FavoriteGameCategory)    // Eagerly load GameCategory
                .Include(mp => mp.LanguagePreference)      // Eagerly load Language
                .FirstOrDefaultAsync(mp => mp.Id == id);

            if (memberPreference == null)
            {
                return NotFound();
            }

            return memberPreference;
        }

        // PUT: api/MemberPreferences/5
        // Updated by lxd
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMemberPreference(MemberPreference memberPreference)
        {
            var existingPreference = await _context.MemberPreference
                .FirstOrDefaultAsync(mp => mp.MemberId == memberPreference.MemberId);

            if (existingPreference != null)
            {
                existingPreference.FavoritePlatform = await _context.FavoritePlatform
                .FirstOrDefaultAsync(p => p.Id == memberPreference.PlatformId);
                existingPreference.FavoriteGameCategory = await _context.GameCategories
                    .FirstOrDefaultAsync(gc => gc.Id == memberPreference.GameCategoryId);
                existingPreference.LanguagePreference = await _context.Language
                    .FirstOrDefaultAsync(l => l.Id == memberPreference.LanguageId);

                if (existingPreference.FavoritePlatform == null || existingPreference.FavoriteGameCategory == null || existingPreference.LanguagePreference == null)
                {
                    return NotFound("One or more preference IDs provided are invalid.");
                }

                _context.Entry(existingPreference).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok(existingPreference);
            }
            return NotFound();
        }

        // POST: api/MemberPreferences
        // Updated by lxd
        [HttpPost]
        public async Task<ActionResult<MemberPreference>> PostMemberPreference(MemberPreference memberPreference)
        {
            // Validate the model state
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            memberPreference.FavoritePlatform = await _context.FavoritePlatform
                .FirstOrDefaultAsync(p => p.Id == memberPreference.PlatformId);
            memberPreference.FavoriteGameCategory = await _context.GameCategories
                .FirstOrDefaultAsync(gc => gc.Id == memberPreference.GameCategoryId);
            memberPreference.LanguagePreference = await _context.Language
                .FirstOrDefaultAsync(l => l.Id == memberPreference.LanguageId);

            // Check if any of the related entities were not found
            if (memberPreference.FavoritePlatform == null || memberPreference.FavoriteGameCategory == null || memberPreference.LanguagePreference == null)
            {
                return NotFound("One or more preference IDs provided are invalid.");
            }

            // Add and save the MemberPreference
            _context.MemberPreference.Add(memberPreference);
            await _context.SaveChangesAsync();

            // Retrieve the newly created preference with related data included
            var createdPreference = await _context.MemberPreference
                .Include(mp => mp.FavoritePlatform)
                .Include(mp => mp.FavoriteGameCategory)
                .Include(mp => mp.LanguagePreference)
                .FirstOrDefaultAsync(mp => mp.Id == memberPreference.Id);

            return CreatedAtAction("GetMemberPreference", new { id = memberPreference.Id }, createdPreference);
        }


        // DELETE: api/MemberPreferences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMemberPreference(Guid id)
        {
            var memberPreference = await _context.MemberPreference
                .Include(mp => mp.FavoritePlatform)
                .Include(mp => mp.FavoriteGameCategory)
                .Include(mp => mp.LanguagePreference)
                .FirstOrDefaultAsync(mp => mp.Id == id);

            if (memberPreference == null)
            {
                return NotFound();
            }

            _context.MemberPreference.Remove(memberPreference);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MemberPreferenceExists(Guid id)
        {
            return _context.MemberPreference.Any(e => e.Id == id);
        }
    }
}

