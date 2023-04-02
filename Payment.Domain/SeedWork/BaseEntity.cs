using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.SeedWork
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        private ICollection<INotification> domainEvents;
        public ICollection<INotification> DomainEvents=>domainEvents;

        public void AddDomainEvents(INotification notification)
        {
            domainEvents ??= new List<INotification>();
            domainEvents.Add(notification);
        }
    }
}
