using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppon._1.termin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Customer customer01 = new Customer
            {
                firstName = "Fabio",
                lastName = "Mandić",
                id = 5748219,
                balance = 800
            };

            Customer customer02 = new Customer
            {
                firstName = "Filip",
                lastName = "Mandić",
                id = 3948424,
                balance = 420
            };

           
            bank.AddCustomer(customer01);
            bank.AddCustomer(customer02);

            Console.WriteLine("\nCustomer01 Account Details:");
            customer01.AccountDetails();

            Console.WriteLine("\nCustomer02 Account Details:");
            customer02.AccountDetails();

            
        }
    }
}
