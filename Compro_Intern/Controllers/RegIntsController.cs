using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Compro_Intern.Daaataaa;
using Compro_Intern.Models;

namespace Compro_Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegIntsController : ControllerBase
    {
        private readonly IntContext _context;

        public RegIntsController(IntContext context)
        {
            _context = context;
        }

        // GET: api/RegInts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegInt>>> GetRegs()
        {
            return await _context.Regs.ToListAsync();
        }

        // GET: api/RegInts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegInt>> GetRegInt(int id)
        {
            var regInt = await _context.Regs.FindAsync(id);

            if (regInt == null)
            {
                return NotFound();
            }

            return regInt;
        }

        // PUT: api/RegInts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegInt(int id, RegInt regInt)
        {
            if (id != regInt.RegIntId)
            {
                return BadRequest();
            }

            _context.Entry(regInt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegIntExists(id))
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

        // POST: api/RegInts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RegInt>> PostRegInt(RegInt regInt)
        {
            _context.Regs.Add(regInt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegInt", new { id = regInt.RegIntId }, regInt);
        }

        // DELETE: api/RegInts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegInt(int id)
        {
            var regInt = await _context.Regs.FindAsync(id);
            if (regInt == null)
            {
                return NotFound();
            }

            _context.Regs.Remove(regInt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegIntExists(int id)
        {
            return _context.Regs.Any(e => e.RegIntId == id);
        }
    }
}
