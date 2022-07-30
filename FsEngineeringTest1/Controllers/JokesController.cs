using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FsEngineeringTest1.Models;

namespace FsEngineeringTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private readonly ChuckDBContext _context;

        public JokesController(ChuckDBContext context)
        {
            _context = context;
        }

        // GET: api/Jokes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jokes>>> GetJokes()
        {
          if (_context.Jokes == null)
          {
              return NotFound();
          }
            return await _context.Jokes.ToListAsync();
        }

        // GET: api/Jokes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jokes>> GetJokes(string id)
        {
          if (_context.Jokes == null)
          {
              return NotFound();
          }
            var jokes = await _context.Jokes.FindAsync(id);

            if (jokes == null)
            {
                return NotFound();
            }

            return jokes;
        }

        // PUT: api/Jokes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJokes(string id, Jokes jokes)
        {
            if (id != jokes.id)
            {
                return BadRequest();
            }

            _context.Entry(jokes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JokesExists(id))
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

        // POST: api/Jokes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jokes>> PostJokes(Jokes jokes)
        {
          if (_context.Jokes == null)
          {
              return Problem("Entity set 'ChuckDBContext.Jokes'  is null.");
          }
            _context.Jokes.Add(jokes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JokesExists(jokes.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJokes", new { id = jokes.id }, jokes);
        }

        // DELETE: api/Jokes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJokes(string id)
        {
            if (_context.Jokes == null)
            {
                return NotFound();
            }
            var jokes = await _context.Jokes.FindAsync(id);
            if (jokes == null)
            {
                return NotFound();
            }

            _context.Jokes.Remove(jokes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JokesExists(string id)
        {
            return (_context.Jokes?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
