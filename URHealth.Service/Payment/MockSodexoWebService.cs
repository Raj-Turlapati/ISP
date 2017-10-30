using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service
{
    public class MockSodexoWebService
    {
        public string ObtainToken(string AccountName, string Password)
        {
            return "S-O-D-E-X-O";
        }

        public string MakePayment(decimal amount, string transactionId, string token)
        {
            return "SODEXO-1111";
        }
    }
}
