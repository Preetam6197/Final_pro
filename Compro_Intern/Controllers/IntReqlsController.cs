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
    public class IntReqlsController : ControllerBase
    {
        private readonly IntContext _context;

        public IntReqlsController(IntContext context)
        {
            _context = context;
        }

        // GET: api/IntReqls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntReql>>> GetLs()
        {
            try
            {
                return await _context.Ls.ToListAsync();

            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/IntReqls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IntReql>> GetIntReql(int id)
        {
            var intReql = await _context.Ls.FindAsync(id);

            if (intReql == null)
            {
                return NotFound();
            }

            return intReql;
        }

        // PUT: api/IntReqls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntReql(int id, IntReql intReql)
        {
            if (id != intReql.LId)
            {
                return BadRequest();
            }

            _context.Entry(intReql).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IntReqlExists(id))
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

        // POST: api/IntReqls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IntReql>> PostIntReql(IntReql intReql)
        {
            try { 
            _context.Ls.Add(intReql);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntReql", new { id = intReql.LId }, intReql);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // DELETE: api/IntReqls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntReql(int id)
        {
            var intReql = await _context.Ls.FindAsync(id);
            if (intReql == null)
            {
                return NotFound();
            }

            _context.Ls.Remove(intReql);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IntReqlExists(int id)
        {
            return _context.Ls.Any(e => e.LId == id);
        }
    }
}
