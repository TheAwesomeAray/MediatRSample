using Request.Interfaces;

namespace Request.Entities
{
    public class EquipmentRequest : IPIMRequest
    {
        public RequestStatus Status { get; set; }

        public bool IsActive()
        {
            throw new System.NotImplementedException();
        }
    }
}
