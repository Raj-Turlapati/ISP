using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth.Service;
using URHealth.Model;
using URHealth.Repository;
using URHealth.Service.BMI;
using URHealth.Service.Message;


namespace ISPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductContext productContext = new ProductContext();
            IProductRepository productRepository = new ProductRepository(productContext);
            ProductService productService = new ProductService(productRepository);
            IList<Product> products = productService.GetAllProducts();                  

            Console.WriteLine("********* UR Health BMI Calculator *********** \n");

            Console.WriteLine("********* BMI Categories *********** \n");
            Console.WriteLine(" Under Weight =< 18.5 \n Normal Weight > 18.5 And <= 24.9 \n Overweight > 25 And <= 29.9 \n Obesity >=30\n");
            Console.WriteLine("********* End of BMI Categories *********** \n");

            BMICalculator calculateBMI = new BMICalculator();

            Console.WriteLine("Enter weight in Kilog grams...");

            float weightInKg;
            float.TryParse(Console.ReadLine(),out weightInKg);
            
            Console.WriteLine("Enter height in Meters...");

            float heightInMeters;
            float.TryParse(Console.ReadLine(), out heightInMeters);

            calculateBMI.WeightInKg = weightInKg;
            calculateBMI.HeightInMeters = heightInMeters;

            float BMI = (float)Math.Round(calculateBMI.Calculate(),1);

            Console.WriteLine("Your BMI is : {0} && BMI Category : {1}", BMI, BMICategory.GetBMICategory(BMI));

            Console.WriteLine("*********  ***********");
            
            Console.WriteLine("********* UR Health Store - Meal Plans ***********");

            foreach (Product product in products)
            {
                Console.WriteLine("Meal: {0}, Name: {1}, Price: Rs.{2}, Calories: {3}", product.Category.Name, product.Name, product.Price, product.Calories);

            }

            Console.WriteLine("********* ********** ***********\n");
            Console.WriteLine("Choose the meal name to place order:");
            string productName = Console.ReadLine();
            Product selectedProduct = products.ToList<Product>().Find(x => x.Name.Contains(productName));
            Console.WriteLine("You have choosen meal: {0}, and price is Rs.{1}", selectedProduct.Name, selectedProduct.Price);
            Console.WriteLine("\n ********* ********** ***********\n");

            Console.WriteLine("Our store supports Zeta / Sodexho.");

            Console.WriteLine("Please enter your card type to proceed for payment...");

            string cardType = Console.ReadLine();

            Console.WriteLine("********* ********** ***********");

            PaymentRequest paymentRequest = new PaymentRequest();

            paymentRequest.Amount = selectedProduct.Price;

            if (cardType == "Sodexho")
                paymentRequest.CardType = MealCardType.Sodexho;
            else if (cardType == "Zeta")
                paymentRequest.CardType = MealCardType.Zeta;

            paymentRequest.PaymentTransactionId = "URHealth" + Guid.NewGuid().ToString();

            PaymentService paymentService = new PaymentService();
            PaymentResponse paymentResponse = paymentService.Pay(paymentRequest);

            string status = ((paymentResponse.Success == true) ? "Thank you for payment! Your transaction is successful.  You'll receive URHealth meal pack in 1 hour." : "Your card is declined, please refer your tranaction id in future communication - " + paymentRequest.PaymentTransactionId);


            Console.WriteLine(status + " \n Transaction message: {0} \n", paymentResponse.Message);

            Console.WriteLine("Would you like to receive receipt thorugh e-mail or sms?\n");

            string msgChoice = Console.ReadLine();

            IMessage messageObject =  null;
            bool isSent;
            string msgResponse = "Receipt is not delivered";

            if(msgChoice.Equals("e-mail"))
            {
                messageObject = new Mail();
                isSent =  messageObject.Send();
                msgResponse = isSent ? "E-mail is successfully sent with URHealth receipt" : "E-mail was not delivered!!!";                        
            
            }
            else if (msgChoice.Equals("sms"))
            {
                messageObject = new SMS();
                isSent = messageObject.Send();
                msgResponse = isSent ? "SMS is successfully sent with URHealth receipt" : "SMS was not delivered!!!";
            }

            Console.WriteLine(msgResponse);

            Console.WriteLine("********* ********** ***********");

            Console.Read();
        }
    }
}
