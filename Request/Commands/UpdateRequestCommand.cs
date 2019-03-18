using MediatR;

namespace Request.Commands
{
    public class UpdateRequestCommand : IRequest<string>
    {
        public int StateId { get; set; }
        public string RequestName { get; set; }
    }
}
