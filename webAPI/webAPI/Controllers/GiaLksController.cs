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
    public class GiaLksController : ControllerBase
    {
        private readonly QLLinhKienMayTinhContext _context;

        public GiaLksController(QLLinhKienMayTinhContext context)
        {
            _context = context;
        }

        // GET: api/GiaLks
        [HttpGet]
        public IEnumerable<GiaLk> GetGiaLk()
        {
            return _context.GiaLk;
        }

        // GET: api/GiaLks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGiaLk([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var giaLk = await _context.GiaLk.FindAsync(id);

            if (giaLk == null)
            {
                return NotFound();
            }

            return Ok(giaLk);
        }

        // PUT: api/GiaLks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGiaLk([FromRoute] string id, [FromBody] GiaLk giaLk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != giaLk.MaLk)
            {
                return BadRequest();
            }

            _context.Entry(giaLk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GiaLkExists(id))
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

        // POST: api/GiaLks
        [HttpPost]
        public async Task<IActionResult> PostGiaLk([FromBody] GiaLk giaLk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GiaLk.Add(giaLk);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GiaLkExists(giaLk.MaLk))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGiaLk", new { id = giaLk.MaLk }, giaLk);
        }

        // DELETE: api/GiaLks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGiaLk([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var giaLk = await _context.GiaLk.FindAsync(id);
            if (giaLk == null)
            {
                return NotFound();
            }

            _context.GiaLk.Remove(giaLk);
            await _context.SaveChangesAsync();

            return Ok(giaLk);
        }

        private bool GiaLkExists(string id)
        {
            return _context.GiaLk.Any(e => e.MaLk == id);
        }
    }
}