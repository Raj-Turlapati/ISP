using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service
{
    public abstract class PaymentServiceBase
    {
        public abstract PaymentResponse PayToVendor(decimal amount, string transactionId);
    }
}
