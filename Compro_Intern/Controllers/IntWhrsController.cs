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
    public class IntWhrsController : ControllerBase
    {
        private readonly IntContext _context;

        public IntWhrsController(IntContext context)
        {
            _context = context;
        }

        // GET: api/IntWhrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntWhr>>> GetHrs()
        {
            try
            {

            
            return await _context.Hrs.ToListAsync();
        }
            catch 
            {
                return NotFound();
            }
         }

        // GET: api/IntWhrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IntWhr>> GetIntWhr(int id)
        {
            var intWhr = await _context.Hrs.FindAsync(id);

            if (intWhr == null)
            {
                return NotFound();
            }

            return intWhr;
        }

        // PUT: api/IntWhrs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntWhr(int id, IntWhr intWhr)
        {
            if (id != intWhr.HId)
            {
                return BadRequest();
            }

            _context.Entry(intWhr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IntWhrExists(id))
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

        // POST: api/IntWhrs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IntWhr>> PostIntWhr(IntWhr intWhr)
        {
            try
            {


                _context.Hrs.Add(intWhr);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetIntWhr", new { id = intWhr.HId }, intWhr);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

            // DELETE: api/IntWhrs/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntWhr(int id)
        {
            var intWhr = await _context.Hrs.FindAsync(id);
            if (intWhr == null)
            {
                return NotFound();
            }

            _context.Hrs.Remove(intWhr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IntWhrExists(int id)
        {
            return _context.Hrs.Any(e => e.HId == id);
        }
    }
}
