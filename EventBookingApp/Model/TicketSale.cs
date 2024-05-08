namespace EventBookingApp.Model
{
    public class TicketSale : BaseEntity
    {
        private string FullName { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }
        private string TicketType { get; set; }
        private int TicketNumber { get; set; }
        private int QuantityBought { get; set; }

        private Events Event { get; set; }
    }
}
