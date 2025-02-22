﻿using System;
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
    public class LanguagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LanguagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Languages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Language>>> GetLanguage()
        {
            return await _context.Language.ToListAsync();
        }

        // GET: api/Languages/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Language>> GetLanguage(Guid id)
        //{
        //    var language = await _context.Language.FindAsync(id);

        //    if (language == null)
        //    {
        //        return NotFound();
        //    }

        //    return language;
        //}

        // PUT: api/Languages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLanguage(Guid id, Language language)
        //{
        //    if (id != language.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(language).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LanguageExists(id))
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

        //// POST: api/Languages
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Language>> PostLanguage(Language language)
        //{
        //    _context.Language.Add(language);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLanguage", new { id = language.Id }, language);
        //}

        //// DELETE: api/Languages/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLanguage(Guid id)
        //{
        //    var language = await _context.Language.FindAsync(id);
        //    if (language == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Language.Remove(language);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool LanguageExists(Guid id)
        //{
        //    return _context.Language.Any(e => e.Id == id);
        //}
    }
}
