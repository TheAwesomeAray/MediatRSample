namespace Request.Interfaces
{
    public interface IPIMRequest
    {
        int StateId { get; }
        RequestStatus Status { get; }
        bool IsActive();
        void Approve();
    }

    public enum RequestStatus
    {
        Pending = 1,
        Active = 2,
        Cancelled = 3,
        Approved = 4,
        Rejected = 5
    }
}
