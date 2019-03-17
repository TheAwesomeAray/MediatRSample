using Request;
using Request.Entities;
using Request.Interfaces;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public class RequestContext : IRequestRepository
    {
        public RequestContext()
        {
            SeedUpdateStateRequests();
        }

        public List<UpdateStateRequest> UpdateStateRequests { get; set; } = new List<UpdateStateRequest>();
        public List<EquipmentRequest> EquipmentRequests { get; set; } = new List<EquipmentRequest>();

        private void SeedUpdateStateRequests()
        {
            UpdateStateRequests.Add(new UpdateStateRequest(1, "Test Request"));
        }
    }
}
