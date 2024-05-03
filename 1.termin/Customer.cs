using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace rppon._1.termin
{
    public class Customer : Person, IBankAccount
    { 
        public decimal balance { get; set; }

        public override string firstName { get; set; }
        public override string lastName { get; set; }
        public override int id { get; set; }


        public void sendMoney(decimal amount)
        {
            balance += amount;
        }

        public void withdrawMoney(decimal amount)
        {
            if(balance>= amount)
            {
                balance-=amount;
            }
            else { 
            Console.WriteLine("insufficient amount on the account");
            }
        }

        public void  AccountDetails()
        {
            Console.WriteLine("Account name: {firstName}");
            Console.WriteLine("Account lastName: {lastName}");
            Console.WriteLine("user id: {id}");
            Console.WriteLine("Total amount: {balance}");
        }
    }
}

