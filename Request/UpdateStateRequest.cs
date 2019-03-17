namespace Request
{
    public class UpdateStateRequest : IRequest
    {
        public RequestStatus Status { get; set; }

        public bool IsActive()
        {
            return Status != RequestStatus.Active && Status != RequestStatus.Pending;
        }
    }
}
