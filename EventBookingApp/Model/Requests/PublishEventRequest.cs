namespace EventBookingApp.Model.Requests
{
    public class PublishEventRequest
    {
        private string EventTitle { get; set; }
        private string EventDescription { get; set; }
        private string EventCategory { get; set; }
        private string Location { get; set; }
        private string Banner { get; set; }
        private string Organizer { get; set; }
        private int AvailableTicket { get; set; }
        private DateTime StartDateTime { get; set; }
        private DateTime EndDateTime { get; set; }


    }
}
