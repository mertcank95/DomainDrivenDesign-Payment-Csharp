using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Events
{
    public class PaymentStartedDomainEvent:INotification
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public  AggregateModels.PaymentModels.Payment Payment { get; set; }

        public PaymentStartedDomainEvent(string customerName, string customerEmail, AggregateModels.PaymentModels.Payment payment)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            Payment = payment;
        }
    }
}
