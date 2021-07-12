using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
         Task Hande(TEvent @event);
    }

    public interface IEventHandler
    {
        
    }
}