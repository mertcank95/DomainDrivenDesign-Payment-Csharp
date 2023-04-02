using Payment.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.AggregateModels.PaymentModels
{
    public class Payment : BaseEntity, IAggregateRoot
    {
        public decimal Price { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public int CustomerId { get; private set; }
        public string Description { get; private set; }
        public Address CustomerAddress { get; private set; }
        public PaymentType CustomerPaymentType { get; private set; }

        public Payment(decimal price, DateTime paymentDate, int customerId, string description,
            Address customerAddress, PaymentType customerPaymentType)
        {
            if (customerPaymentType.Id.Equals(-1))
                throw new Exception("eror:");
            Price = price;
            PaymentDate = paymentDate;
            CustomerId = customerId;
            Description = description;
            CustomerAddress = customerAddress;
            CustomerPaymentType = customerPaymentType;
        }
    }


}
