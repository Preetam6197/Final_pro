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
    public class IntDesgsController : ControllerBase
    {
        private readonly IntContext _context;

        public IntDesgsController(IntContext context)
        {
            _context = context;
        }

        // GET: api/IntDesgs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntDesg>>> GetDesgs()
        {
            try
            {
                return await _context.Desgs.ToListAsync();
            }

            catch
            {
                return NotFound();

            }

        }

        // GET: api/IntDesgs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IntDesg>> GetIntDesg(int id)
        {
            var intDesg = await _context.Desgs.FindAsync(id);

            if (intDesg == null)
            {
                return NotFound();
            }

            return intDesg;
        }

        // PUT: api/IntDesgs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntDesg(int id, IntDesg intDesg)
        {
            if (id != intDesg.DesgId)
            {
                return BadRequest();
            }

            _context.Entry(intDesg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IntDesgExists(id))
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

        // POST: api/IntDesgs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IntDesg>> PostIntDesg(IntDesg intDesg)
        {
            try
            {

            
            _context.Desgs.Add(intDesg);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntDesg", new { id = intDesg.DesgId }, intDesg);
            }

            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // DELETE: api/IntDesgs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntDesg(int id)
        {
            var intDesg = await _context.Desgs.FindAsync(id);
            if (intDesg == null)
            {
                return NotFound();
            }

            _context.Desgs.Remove(intDesg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IntDesgExists(int id)
        {
            return _context.Desgs.Any(e => e.DesgId == id);
        }
    }
}
