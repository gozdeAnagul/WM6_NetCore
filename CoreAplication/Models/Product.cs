using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAplication.Models
{
    [Table("Urunler")]
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required, StringLength(50), Column("UrunAdi")]
        public string ProductName { get; set; }
        [Column("Fİyat")]
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
