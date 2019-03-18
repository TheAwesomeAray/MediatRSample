using MediatR;

namespace Request.Commands
{
    public class ApproveRequestCommand : IRequest
    {
        public int RequestId { get; set; }
    }
}
