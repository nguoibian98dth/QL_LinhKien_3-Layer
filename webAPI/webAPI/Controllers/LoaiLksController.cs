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
    public class LoaiLksController : ControllerBase
    {
        private readonly QLLinhKienMayTinhContext _context;

        public LoaiLksController(QLLinhKienMayTinhContext context)
        {
            _context = context;
        }

        // GET: api/LoaiLks
        [HttpGet]
        public IEnumerable<LoaiLk> GetLoaiLk()
        {
            return _context.LoaiLk;
        }

        // GET: api/LoaiLks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoaiLk([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loaiLk = await _context.LoaiLk.FindAsync(id);

            if (loaiLk == null)
            {
                return NotFound();
            }

            return Ok(loaiLk);
        }

        // PUT: api/LoaiLks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaiLk([FromRoute] string id, [FromBody] LoaiLk loaiLk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != loaiLk.MaLoai)
            {
                return BadRequest();
            }

            _context.Entry(loaiLk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiLkExists(id))
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

        // POST: api/LoaiLks
        [HttpPost]
        public async Task<IActionResult> PostLoaiLk([FromBody] LoaiLk loaiLk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.LoaiLk.Add(loaiLk);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoaiLkExists(loaiLk.MaLoai))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoaiLk", new { id = loaiLk.MaLoai }, loaiLk);
        }

        // DELETE: api/LoaiLks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoaiLk([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loaiLk = await _context.LoaiLk.FindAsync(id);
            if (loaiLk == null)
            {
                return NotFound();
            }

            _context.LoaiLk.Remove(loaiLk);
            await _context.SaveChangesAsync();

            return Ok(loaiLk);
        }

        private bool LoaiLkExists(string id)
        {
            return _context.LoaiLk.Any(e => e.MaLoai == id);
        }
    }
}