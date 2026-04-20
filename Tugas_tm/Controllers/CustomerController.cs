using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tugas_tm.Data;
using Tugas_tm.Models;

namespace Tugas_tm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.Customers.ToListAsync();
            return Ok(data);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _context.Customers.FindAsync(id);

            if (data == null)
                return NotFound(new { message = "Data tidak ditemukan" });

            return Ok(data);
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(customer);
        }

        // PUT (UPDATE)
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Customer customer)
        {
            var data = await _context.Customers.FindAsync(id);

            if (data == null)
                return NotFound(new { message = "Data tidak ditemukan" });

            data.NamaCustomer = customer.NamaCustomer;
            data.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(data);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _context.Customers.FindAsync(id);

            if (data == null)
                return NotFound(new { message = "Data tidak ditemukan" });

            _context.Customers.Remove(data);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil dihapus" });
        }
    }
}