using Payment.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Infurastructure.Repository
{
    public class PaymentRepository:IPaymentRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(0);
        }
    }
}
