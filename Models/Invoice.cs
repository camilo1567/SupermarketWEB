namespace FirstWebApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int PayModeId { get; set; }

        public ICollection<Customer>? Customer { get; set; } = default!;
        public ICollection<PayMode>? PayMode { get; set; } = default!;
    }
}
