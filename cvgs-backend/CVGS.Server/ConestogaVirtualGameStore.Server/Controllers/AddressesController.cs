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
    public class AddressesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AddressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Addresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddresses()
        {
            return await _context.Addresses.ToListAsync();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(Guid id)
        {
            var address = await _context.Addresses.FindAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(Guid id, Address address)
        {
            if (id != address.AddressID)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
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

        // POST: api/Addresses (Modify by LXD)
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            if (string.IsNullOrEmpty(address.MemberID))
            {
                return BadRequest("MemberID is required to associate an address with a user profile.");
            }

            // Check if the UserProfile exists in the database
            var userProfile = await _context.UserProfiles
                                            .Include(up => up.Addresses) // Include addresses for the user
                                            .FirstOrDefaultAsync(up => up.UserId == address.MemberID);
            if (userProfile == null)
            {
                return BadRequest("User profile does not exist.");
            }

            // Check if the user already has an address
            var existingAddress = userProfile.Addresses.FirstOrDefault();
            if (existingAddress != null)
            {
                // Update the existing address with the new information
                existingAddress.Country = address.Country;
                existingAddress.FullName = address.FullName;
                existingAddress.PhoneNumber = address.PhoneNumber;
                existingAddress.StreetAddress = address.StreetAddress;
                existingAddress.AptSuite = address.AptSuite;
                existingAddress.City = address.City;
                existingAddress.Province = address.Province;
                existingAddress.PostalCode = address.PostalCode;
                existingAddress.DeliveryInstructions = address.DeliveryInstructions;

                _context.Entry(existingAddress).State = EntityState.Modified;
            }
            else
            {
                // If no existing address, add a new one
                address.UserProfile = userProfile;
                _context.Addresses.Add(address);
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress", new { id = address.AddressID }, address);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(Guid id)
        {
            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddressExists(Guid id)
        {
            return _context.Addresses.Any(e => e.AddressID == id);
        }
    }
}
