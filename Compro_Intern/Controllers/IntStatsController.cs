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
    public class IntStatsController : ControllerBase
    {
        private readonly IntContext _context;

        public IntStatsController(IntContext context)
        {
            _context = context;
        }

        // GET: api/IntStats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntStat>>> GetSts()
        {
            return await _context.Sts.ToListAsync();
        }

        // GET: api/IntStats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IntRec>> GetIntStat(int id)
        {
            IntRec intStat = await _context.Recs.FindAsync(id);

            if (intStat == null)
            {
                return NotFound();
            }

            return intStat;

        }


        //// GET: api/IntStats/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IntStat>> GetIntStat(int id)
        //{
        //    var intStat = await _context.Sts.FindAsync(id);

        //    if (intStat == null)
        //    {
        //        return NotFound();
        //    }

        //    return intStat;
        //}
            //var employees = (from e in _context.Sts
            //                 join d in _context.Recs
            //                 on Id equals d.RecId

            //                 select new Employee
            //                 {
            //                     Id = e.Id,
            //                     Name = e.Name,
            //                     LastName = e.LastName,
            //                     Email = e.Email,
            //                     Age = e.Age,
            //                     DesignationID = e.DesignationID,
            //                     Designation = d.Designation_name,
            //                     Doj = e.Doj,
            //                     Gender = e.Gender,
            //                     IsActive = e.IsActive,
            //                     IsMarried = e.IsMarried
            //                 }
            //           ).ToListAsync();




            //return await employees;
        

        // PUT: api/IntStats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntStat(int id, IntStat intStat)
        {
            if (id != intStat.SId)
            {
                return BadRequest();
            }

            _context.Entry(intStat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IntStatExists(id))
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

        // POST: api/IntStats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IntStat>> PostIntStat(IntStat intStat)
        {
            _context.Sts.Add(intStat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntStat", new { id = intStat.SId }, intStat);
        }

        // DELETE: api/IntStats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntStat(int id)
        {
            var intStat = await _context.Sts.FindAsync(id);
            if (intStat == null)
            {
                return NotFound();
            }

            _context.Sts.Remove(intStat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IntStatExists(int id)
        {
            return _context.Sts.Any(e => e.SId == id);
        }
    }
}
