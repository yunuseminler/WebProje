using G191210046.Data;
using G191210046.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace G191210046.API
{
    namespace WebProgrammingUrun.API
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UrunController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public UrunController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: api/Urun
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Urun>>> GetUrun()
            {
                return await _context.Urun.ToListAsync();
            }

            // GET: api/Urun/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Urun>> GetUrun(int id)
            {
                var Urun = await _context.Urun.FindAsync(id);

                if (Urun == null)
                {
                    return NotFound();
                }

                return Urun;
            }

            // PUT: api/Urun/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutUrun(int id, Urun Urun)
            {
                if (id != Urun.Id)
                {
                    return BadRequest();
                }

                _context.Entry(Urun).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrunExists(id))
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

            // POST: api/Urun
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Urun>> PostUrun(Urun Urun)
            {
                _context.Urun.Add(Urun);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUrun", new { id = Urun.Id }, Urun);
            }

            // DELETE: api/Urun/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteUrun(int id)
            {
                var Urun = await _context.Urun.FindAsync(id);
                if (Urun == null)
                {
                    return NotFound();
                }

                _context.Urun.Remove(Urun);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool UrunExists(int id)
            {
                return _context.Urun.Any(e => e.Id == id);
            }
        }
    }
}
