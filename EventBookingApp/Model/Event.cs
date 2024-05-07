namespace EventBookingApp.Model
{
    public class Event : AuditBaseEntity
    {
        private long EventId { get; set; }
        private string EventTitle { get; set; }
        private string EventDescription { get; set; }
        private string EventCategory { get; set; }
        private string Location { get; set; }
        private string Banner { get; set; }
        private string Organizer { get; set; }
        private int AvailableTicket { get; set; }
        private int TicketSold { get; set; }
        private int RevenueGenerated { get; set; }
        private DateTime StartDateTime { get; set; }
        private DateTime EndDateTime { get; set; }
        private bool Published { get; set; }
        private bool Paid { get; set; } = false;

        private User user { get; set; }
        private List<Ticket> Tickets { get; set; }
        private AccountDetails accountDetails { get; set; }
    }
}
