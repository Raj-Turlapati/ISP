using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service
{
    public class MockZetaWebService
    {
        public string MakePayment(decimal amount, string transactionId, string username, string password, string ProductId)
        {
            return "Z-E-T-A-1111";
        }
    }
}
