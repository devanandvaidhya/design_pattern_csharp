using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Strategy_Pattern
{
    public interface PaymentStrategy
    {
        void paymentProcess();
    }

    public class CreditCard : PaymentStrategy
    {
        public void paymentProcess()
        {
            Console.WriteLine("Making payment via Credit card");
        }
    }
    public class DebitCard : PaymentStrategy
    {
        public void paymentProcess()
        {
            Console.WriteLine("Making payment via Debit card");
        }
    }
    //Newly added UPI class
    public class UPI : PaymentStrategy
    {
        public void paymentProcess()
        {
            Console.WriteLine("Making payment via UPI");
        }
    }

    public class PaymentServices
    {
        private PaymentStrategy stratergy;
        public PaymentServices()
        {
        }

        public void setPayment(PaymentStrategy paymentStrategy)
        { 
            stratergy = paymentStrategy;

        }
        public void payment() {
            stratergy.paymentProcess();
        }
    }

    public class StrategyPattern
    {

        public void MainMethod()
        {
            PaymentServices paymentServices = new PaymentServices();
            //paymentService.setPayment(new CreditCard());
            //paymentService.setPayment(new DebitCard());
            //added new UPI payment method 

            paymentServices.setPayment(new UPI());
            paymentServices.payment();
        }

    }
}
