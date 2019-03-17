using Request.Interfaces;

namespace Request.Entities
{
    public class EquipmentRequest : IPIMRequest
    {
        public int StateId { get; private set; }
        public RequestStatus Status { get; set; }

        public bool IsActive()
        {
            return false;
        }
    }
}
