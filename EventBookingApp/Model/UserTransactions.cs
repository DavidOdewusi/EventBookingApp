namespace EventBookingApp.Model
{
    public class UserTransactions : AuditBaseEntity
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private double Amount { get; set; }
        private string Currency { get; set; }
        private string Reference { get; set; }
        private string CallBackUrl { get; set; }
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private bool IsVerified { get; set; } = false;
    }
}
