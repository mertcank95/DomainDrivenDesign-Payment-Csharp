using MediatR;
using Payment.Application.Repository;
using Payment.Domain.AggregateModels.CustomerModels;
using Payment.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Application.PaymentEventHandlers
{
    public class PaymentStartedDomainEventHandler : INotificationHandler<PaymentStartedDomainEvent>
    {

        private readonly ICustomerRepository _customerRepository;

        public PaymentStartedDomainEventHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentException(nameof(customerRepository));
        }

        public Task Handle(PaymentStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            var customer = new Customer(notification.CustomerName, notification.CustomerEmail);

            return Task.CompletedTask;
        }
    }
}
