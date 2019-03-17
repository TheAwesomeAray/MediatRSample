using Request.Interfaces;
using Request.Specifications;

namespace Request.Entities
{
    public class UpdateStateRequest : IPIMRequest
    {
        public int Id { get; set; }
        public string RequestName { get; set; }
        public int StateId { get; private set; }
        public RequestStatus Status { get; private set; } = RequestStatus.Pending;

        public UpdateStateRequest(int stateId, string requestName)
        {
            StateId = stateId;
            RequestName = requestName;
        }

        public bool IsActive()
        {
            var test2 = Status != RequestStatus.Active && Status != RequestStatus.Pending;
            var test = new StatusIsActiveSpecification().Evaluate(this);
            return new StatusIsActiveSpecification().Evaluate(this);
        }
    }
}
