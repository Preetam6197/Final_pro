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
    public class IntRecsController : ControllerBase
    {
        private readonly IntContext _context;

        public IntRecsController(IntContext context)
        {
            _context = context;
        }

        // GET: api/IntRecs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntRec>>> GetRecs()
        {
            try
            {
                return await _context.Recs.ToListAsync();

            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/IntRecs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IntRec>> GetIntRec(int id)
        {
            var intRec = await _context.Recs.FindAsync(id);

            if (intRec == null)
            {
                return NotFound();
            }

            return intRec;
        }

        // PUT: api/IntRecs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntRec(int id, IntRec intRec)
        {
            if (id != intRec.RecId)
            {
                return BadRequest();
            }

            _context.Entry(intRec).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IntRecExists(id))
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

        // POST: api/IntRecs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IntRec>> PostIntRec(IntRec intRec)
        {
            try
            {

            
            _context.Recs.Add(intRec);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntRec", new { id = intRec.RecId }, intRec);
            }
            catch (Exception e)
            {
                
                return NotFound(e.Message);
            }
        }

        // DELETE: api/IntRecs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntRec(int id)
        {
            var intRec = await _context.Recs.FindAsync(id);
            if (intRec == null)
            {
                return NotFound();
            }

            _context.Recs.Remove(intRec);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IntRecExists(int id)
        {
            return _context.Recs.Any(e => e.RecId == id);
        }
    }
}
