using Request;
using System.Collections.Generic;

namespace Infrastructure
{
    public class RequestContext
    {
        public List<UpdateStateRequest> UpdateStateRequests { get; set; }
    }
}
