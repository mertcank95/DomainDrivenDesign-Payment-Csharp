using Payment.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.AggregateModels.PaymentModels
{
    public class PaymentType : BaseEntity
    {
        public string PaymentMethodsName { get; set; }
        public int PaymentMethodsId { get; set; }

    }
}
