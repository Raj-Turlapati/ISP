using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service
{
    public class PaymentService
    {
        public PaymentResponse Pay(PaymentRequest paymentRequest)
        {
            PaymentServiceBase paymentService = PaymentServiceFactory.GetPaymentServiceFrom(paymentRequest.CardType);
            PaymentResponse paymentResponse;

            paymentResponse = paymentService.PayToVendor(paymentRequest.Amount, paymentRequest.PaymentTransactionId);

            return paymentResponse;
        }
    }
}
