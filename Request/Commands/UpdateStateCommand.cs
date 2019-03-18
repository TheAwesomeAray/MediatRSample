using MediatR;

namespace Request.Commands
{
    public class UpdateStateCommand : IRequest
    {
        public int StateId { get; set; }
    }
}
