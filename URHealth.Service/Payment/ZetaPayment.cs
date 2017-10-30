using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service
{
    public class ZetaPayment : PaymentServiceBase
    {
        public ZetaPayment(string AccountId, string AccountPassword, string ProductId)
        {
            this.AccountId = AccountId;
            this.AccountPassword = AccountPassword;
            this.ProductId = ProductId;
        }

        public string AccountId { get; set; }
        public string AccountPassword { get; set; }
        public string ProductId { get; set; }
        public override PaymentResponse PayToVendor(decimal amount, string transactionId)
        {
            PaymentResponse paymentResponse = new PaymentResponse();
            MockZetaWebService worldPayWebService = new MockZetaWebService();

            string response = worldPayWebService.MakePayment(amount, transactionId, AccountId, AccountPassword, ProductId);

            paymentResponse.Message = response;

            if (response.Contains("Z-E-T-A"))
                paymentResponse.Success = true;
            else
                paymentResponse.Success = false;

            return paymentResponse;
        }
    }
}
