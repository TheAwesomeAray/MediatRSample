using MediatR;

namespace Request.Events
{
    public class RequestApprovedEvent : IRequest
    {
        public int RequestId { get; set; }
    }
}
