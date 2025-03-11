using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.StructuralPatterns.Facade_Patterns
{
    public class FacadePattern
    {
        public void MainMethod()
        {
            // Client code interacting with different services directly
            // UserService userService = new UserService();
            // OrderService orderService = new OrderService();
            // PaymentService paymentService = new PaymentService();

            //Console.WriteLine(userService.getUserDetails("123"));
            // Console.WriteLine(orderService.getOrderDetails("456"));
            // Console.WriteLine(paymentService.getPaymentDetails("789"));

            //Facade Pattern 
            // Client code interacting with API Gateway (Facade)
            APIGateway apiGateway = new APIGateway();
            //Task
            Console.WriteLine(apiGateway.getFullDetails("123", "456", "789"));


        }
    }

    public class UserService
    {
        public string getUserDetails(string userId)
        {
            return "User details for user Id: " + userId;
        }
    }
    public class OrderService
    {
        public string getOrderDetails(string orderId)
        {
            return "Order details for order Id: " + orderId;
        }
    }
    public class PaymentService
    {
        public string getPaymentDetails(string paymentId)
        {
            return "Payment details for payment Id: " + paymentId;
        }
    }


    public class APIGateway
    {
        UserService userService;
        PaymentService paymentService;
        OrderService orderService;

        public APIGateway()
        {
            userService = new UserService();
            orderService = new OrderService();
            paymentService = new PaymentService();
        }

        public string getFullDetails(string paymentId, string orderid, string userId) {
            string userDetails = userService.getUserDetails(userId);
            string orderDetails = orderService.getOrderDetails(orderid);
            string paymentProcessing = paymentService.getPaymentDetails(paymentId);
            return userDetails + "\n" + orderDetails + "\n" + paymentProcessing;
        }
    }

}
