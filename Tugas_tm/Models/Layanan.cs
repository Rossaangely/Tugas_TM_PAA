using System.ComponentModel.DataAnnotations.Schema;

namespace Tugas_tm.Models
{
    [Table("layanan")]
    public class Layanan
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nama_layanan")]
        public string NamaLayanan { get; set; } = string.Empty;

        [Column("harga")]
        public decimal Harga { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}