using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThamsoesController : ControllerBase
    {
        private readonly QLLinhKienMayTinhContext _context;

        public ThamsoesController(QLLinhKienMayTinhContext context)
        {
            _context = context;
        }

        // GET: api/Thamsoes
        [HttpGet]
        public IEnumerable<Thamso> GetThamso()
        {
            return _context.Thamso;
        }

        // GET: api/Thamsoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetThamso([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var thamso = await _context.Thamso.FindAsync(id);

            if (thamso == null)
            {
                return NotFound();
            }

            return Ok(thamso);
        }

        // PUT: api/Thamsoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThamso([FromRoute] string id, [FromBody] Thamso thamso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != thamso.MaTs)
            {
                return BadRequest();
            }

            _context.Entry(thamso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThamsoExists(id))
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

        // POST: api/Thamsoes
        [HttpPost]
        public async Task<IActionResult> PostThamso([FromBody] Thamso thamso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Thamso.Add(thamso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ThamsoExists(thamso.MaTs))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetThamso", new { id = thamso.MaTs }, thamso);
        }

        // DELETE: api/Thamsoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThamso([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var thamso = await _context.Thamso.FindAsync(id);
            if (thamso == null)
            {
                return NotFound();
            }

            _context.Thamso.Remove(thamso);
            await _context.SaveChangesAsync();

            return Ok(thamso);
        }

        private bool ThamsoExists(string id)
        {
            return _context.Thamso.Any(e => e.MaTs == id);
        }
    }
}