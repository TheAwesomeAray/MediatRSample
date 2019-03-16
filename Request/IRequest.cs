namespace Request
{
    public interface IRequest
    {
        RequestStatus Status { get; set; }
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
