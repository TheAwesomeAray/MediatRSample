using MediatR;
using Request.Entities;
using Request.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Infrastructure
{
    public class RequestContext : DbContext, IRequestRepository
    {
        private IMediator _mediator;

        public RequestContext(IMediator mediator)

        {
            _mediator = mediator;
            SeedUpdateStateRequests();
        }

        public List<UpdateStateRequest> UpdateStateRequests { get; set; } = new List<UpdateStateRequest>();
        public List<EquipmentRequest> EquipmentRequests { get; set; } = new List<EquipmentRequest>();

        private void SeedUpdateStateRequests()
        {
            UpdateStateRequests.Add(new UpdateStateRequest(1, "Test Request"));
        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();

            var eventfulEntries = ChangeTracker.Entries<IEventful>();
            var requests = eventfulEntries.SelectMany(x => x.Entity.Requests);
            var notifications = eventfulEntries.SelectMany(x => x.Entity.Notifications);

            foreach (var request in requests)
            {
                _mediator.Send(request);
            }

            foreach (var notification in notifications)
            {
                _mediator.Publish(notification);
            }

            return result;
        }
    }
}
