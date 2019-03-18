using MediatR;
using System.Collections.Generic;

namespace Request.Interfaces
{
    public interface IEventful
    {
        IReadOnlyList<IRequest> Requests { get; }
        IReadOnlyList<INotification> Notifications { get; }
    }
}
