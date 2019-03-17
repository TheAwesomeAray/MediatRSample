using Request.Entities;
using System.Collections.Generic;

namespace Request.Interfaces
{
    public interface IRequestRepository
    {
        List<UpdateStateRequest> UpdateStateRequests { get; set; }
        List<EquipmentRequest> EquipmentRequests { get; set; }
    }
}
