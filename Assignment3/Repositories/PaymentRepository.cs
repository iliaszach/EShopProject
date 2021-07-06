using Assignment3.PaymentMethodStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repositories
{
    public class PaymentRepository
    {
        public IPaymentMethod PaymentMethod()
        {
            Console.WriteLine("Choose payment method");
            Console.WriteLine("1 - Debit");
            Console.WriteLine("2 - Bank");
            Console.WriteLine("3 - Cash");
            string paymentInput = Console.ReadLine();
            IPaymentMethod UserpaymentMethod;
            switch (paymentInput)
            {
                case "1": UserpaymentMethod = new DebitCardStrategy(); break;
                case "2": UserpaymentMethod = new BankTransferStrategy(); break;
                case "3": UserpaymentMethod = new CashStrategy(); break;
                default: UserpaymentMethod = new CashStrategy(); break;
            }
            return UserpaymentMethod;
        }
    }
}
