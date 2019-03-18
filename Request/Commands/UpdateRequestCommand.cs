using MediatR;

namespace Application.Requests
{
    public class UpdateRequestCommand : IRequest<string>
    {
        public int StateId { get; set; }
        public string RequestName { get; set; }
    }
}
