namespace Request
{
    internal class ExampleRequest : IRequest
    {
        public RequestStatus Status { get; set; }

        public bool IsActive()
        {
            return Status != RequestStatus.Active && Status != RequestStatus.Pending;
        }
    }
}
