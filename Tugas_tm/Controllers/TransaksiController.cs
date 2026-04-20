using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tugas_tm.Data;
using Tugas_tm.Models;

namespace Tugas_tm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransaksiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransaksiController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL + RELASI
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.Transaksis
                .Include(t => t.Customer)
                .Include(t => t.Layanan)
                .ToListAsync();

            return Ok(data);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _context.Transaksis
                .Include(t => t.Customer)
                .Include(t => t.Layanan)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (data == null)
                return NotFound(new { message = "Data tidak ditemukan" });

            return Ok(data);
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> Create(Transaksi transaksi)
        {
            transaksi.CreatedAt = DateTime.UtcNow;
            transaksi.UpdatedAt = DateTime.UtcNow;

            _context.Transaksis.Add(transaksi);
            await _context.SaveChangesAsync();

            return Ok(transaksi);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Transaksi transaksi)
        {
            var data = await _context.Transaksis.FindAsync(id);

            if (data == null)
                return NotFound(new { message = "Data tidak ditemukan" });

            data.CustomerId = transaksi.CustomerId;
            data.LayananId = transaksi.LayananId;
            data.Total = transaksi.Total;
            data.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(data);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _context.Transaksis.FindAsync(id);

            if (data == null)
                return NotFound(new { message = "Data tidak ditemukan" });

            _context.Transaksis.Remove(data);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil dihapus" });
        }
    }
}