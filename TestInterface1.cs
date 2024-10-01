using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal interface TestInterface
    {
        //method declaration

        void MakePayment(decimal amount);

        void RefundPayment(decimal amount);


    }
    public class CreditCardPayment:TestInterface, TestInterface2
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Credit Card payment of{amount} has been made");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card refund of{amount} has been made");
        }
        public void UPIPayment(decimal amount)
        {
            Console.WriteLine($"UPI Payment refund of{amount} has been made");
        }
    }

    public class PaypalPayment : TestInterface
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"PayPal payment of{amount} has been made");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"PayPal Payment refund of{amount} has been made");
        }
    }

    internal interface TestInterface2
    {
        void UPIPayment(decimal amount);
    }

    public class TestInterface1
    {
        static void Main()
        {
            //cradit card payment class
            TestInterface creditcard = new CreditCardPayment();
            creditcard.MakePayment(100.5m);
            creditcard.RefundPayment(50.5m);
            TestInterface2 upi=new CreditCardPayment();
            upi.UPIPayment(60.56m);


            //paypal class

            TestInterface paypal=new PaypalPayment();

            paypal.MakePayment(60.52m);
            paypal.RefundPayment(30.54m);

        }
    }
}
