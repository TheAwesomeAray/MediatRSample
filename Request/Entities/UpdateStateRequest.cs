using Request.Interfaces;
using Request.Specifications;

namespace Request.Entities
{
    public class UpdateStateRequest : IPIMRequest
    {
        public RequestStatus Status { get; private set; }

        public bool IsActive()
        {
            return new StatusIsActiveSpecification().Evaluate(this);
        }
    }
}
