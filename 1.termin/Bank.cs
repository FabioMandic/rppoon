using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppon._1.termin
{
    public class Bank
    {
        public List<Transaction> transactions;
        public List<Customer> customers;

        public Bank()
        {
            transactions = new List<Transaction>();
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void DoTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public Customer FindCustomer(int id)
        {
            var customerFind=customers.Where(x=>x.id==id)
                                      .FirstOrDefault();
            return customerFind;
        }
    }
}
