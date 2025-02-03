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

    public class PaymentService
    {
        private PaymentStrategy stratergy;
        public PaymentService()
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
}
