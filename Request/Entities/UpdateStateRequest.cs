using System.Collections.Generic;
using MediatR;
using Request.Interfaces;
using Request.Specifications;

namespace Request.Entities
{
    public class UpdateStateRequest : IPIMRequest, IEventful
    {
        public int Id { get; set; }
        public string RequestName { get; set; }
        public int StateId { get; private set; }
        public RequestStatus Status { get; private set; } = RequestStatus.Pending;

        private List<IRequest> _requests { get; set; } = new List<IRequest>();
        private List<INotification> _notifications { get; set; } = new List<INotification>();
        public IReadOnlyList<IRequest> Requests => _requests.AsReadOnly();
        public IReadOnlyList<INotification> Notifications => _notifications.AsReadOnly();

        public UpdateStateRequest(int stateId, string requestName)
        {
            StateId = stateId;
            RequestName = requestName;
        }

        public bool IsActive()
        {
            return new StatusIsActiveSpecification().Evaluate(this);
        }

        public void Approve()
        {
            Status = RequestStatus.Approved;
            //_requests.Add(new )
        }
    }
}
