using Microsoft.EntityFrameworkCore;
using Tugas_tm.Models;

namespace Tugas_tm.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Layanan> Layanans { get; set; }
        public DbSet<Transaksi> Transaksis { get; set; }
    }
}