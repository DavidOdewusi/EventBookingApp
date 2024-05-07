namespace EventBookingApp.Model
{
    public abstract class AuditBaseEntity
    {
        private DateTime CreatedAt;
        private DateTime LastUpdatedAt;

        protected AuditBaseEntity() { 
            CreatedAt = DateTime.UtcNow;
            LastUpdatedAt = DateTime.UtcNow;
        }

        protected void OnCreate()
        {
            this.CreatedAt = DateTime.UtcNow; 
            this.LastUpdatedAt = DateTime.UtcNow;
        }

        
        protected void OnUpdated()
        {
            this.LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
