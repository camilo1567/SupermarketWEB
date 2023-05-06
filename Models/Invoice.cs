namespace FirstWebApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int PayModeId { get; set; }

        public Customer Customer { get; set; } = default!;
        public PayMode PayMode { get; set; } = default!;
    }
}
