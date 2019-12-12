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
    public class LinhkiensController : ControllerBase
    {
        private readonly QLLinhKienMayTinhContext _context;

        public LinhkiensController(QLLinhKienMayTinhContext context)
        {
            _context = context;
        }

        // GET: api/Linhkiens
        [HttpGet]
        public IEnumerable<Linhkien> GetLinhkien()
        {
            return _context.Linhkien;
        }

        // GET: api/Linhkiens/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLinhkien([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var linhkien = await _context.Linhkien.FindAsync(id);

            if (linhkien == null)
            {
                return NotFound();
            }

            return Ok(linhkien);
        }

        // PUT: api/Linhkiens/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinhkien([FromRoute] string id, [FromBody] Linhkien linhkien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != linhkien.MaLk)
            {
                return BadRequest();
            }

            _context.Entry(linhkien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinhkienExists(id))
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

        // POST: api/Linhkiens
        [HttpPost]
        public async Task<IActionResult> PostLinhkien([FromBody] Linhkien linhkien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Linhkien.Add(linhkien);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LinhkienExists(linhkien.MaLk))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLinhkien", new { id = linhkien.MaLk }, linhkien);
        }

        // DELETE: api/Linhkiens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLinhkien([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var linhkien = await _context.Linhkien.FindAsync(id);
            if (linhkien == null)
            {
                return NotFound();
            }

            _context.Linhkien.Remove(linhkien);
            await _context.SaveChangesAsync();

            return Ok(linhkien);
        }

        private bool LinhkienExists(string id)
        {
            return _context.Linhkien.Any(e => e.MaLk == id);
        }
    }
}