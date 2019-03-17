using Request;
using Request.Entities;
using Request.Interfaces;
using System.Collections.Generic;

namespace Infrastructure
{
    public class RequestContext : IRequestRepository
    {
        public List<UpdateStateRequest> UpdateStateRequests { get; set; }
        public List<EquipmentRequest> EquipmentRequests { get; set; }
    }
}
