using System.ComponentModel.DataAnnotations.Schema;

namespace Tugas_tm.Models
{
    [Table("transaksi")]
    public class Transaksi
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("layanan_id")]
        public int LayananId { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Customer Customer { get; set; }
        public Layanan Layanan { get; set; }
    }
}