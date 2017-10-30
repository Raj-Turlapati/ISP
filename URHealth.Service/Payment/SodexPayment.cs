using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service
{
    public class SodexhoPayment : PaymentServiceBase
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public SodexhoPayment(string AccountName, string Password)
        {
            this.AccountName = AccountName;
            this.Password = Password;
        }

        public override PaymentResponse PayToVendor(decimal amount, string transactionId)
        {
            MockSodexoWebService sodexoWebService = new MockSodexoWebService();
            PaymentResponse paymentResponse = new PaymentResponse();

            string token = sodexoWebService.ObtainToken(AccountName, Password);

            string response = sodexoWebService.MakePayment(amount, transactionId, token);

            paymentResponse.Message = response;

            if (response.Contains("SODEXO-1111"))
                paymentResponse.Success = true;
            else
                paymentResponse.Success = false;

            return paymentResponse;
            
        }
    }
}
