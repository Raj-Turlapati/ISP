using System;

namespace URHealth.Service
{
    public class PaymentServiceFactory
    {
        public static PaymentServiceBase GetPaymentServiceFrom(MealCardType mealCardType)
        {
           switch(mealCardType)
            {
                case MealCardType.Sodexho:
                    return new SodexhoPayment("Tom", "Password");
                case MealCardType.Zeta:
                    return new ZetaPayment("Jerry", "Password;1", "1");
                default:

                    throw new ApplicationException("No Payment Service available for " + mealCardType.ToString());

            }
        }
    }
}