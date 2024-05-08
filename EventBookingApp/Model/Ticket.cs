namespace EventBookingApp.Model
{
    public class Ticket
    {
        private long TicketId { get; set; }
        private string ticket {  get; set; }
        private double Cost { get; set; }
        private int TotalQuantity { get; set; }
        private int QuantitySold { get; set; }
        private int QuantityLeft { get; set; }

        private Events Event { get; set; }
    }
}
