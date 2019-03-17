namespace Request.Interfaces
{
    public interface IPIMRequest
    {
        int StateId { get; }
        RequestStatus Status { get; }
        bool IsActive();
    }

    public enum RequestStatus
    {
        Pending = 1,
        Active = 2,
        Cancelled = 3,
        Accepted = 4,
        Rejected = 5
    }
}
