using Request.Interfaces;
using System;
using System.Linq.Expressions;

namespace Request.Specifications
{
    public class StatusIsActiveSpecification : BaseSpecification<IPIMRequest>
    {
        public StatusIsActiveSpecification()
            : base(r => r.Status != RequestStatus.Active && r.Status != RequestStatus.Pending)
        { }
    }
}
