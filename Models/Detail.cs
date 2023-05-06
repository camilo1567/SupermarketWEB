using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApp.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public ICollection<Product>? Products { get; set; } = default!;
        public ICollection<Invoice>? Invoices { get; set; } = default!;
    }
}
