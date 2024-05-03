using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppon._1.termin
{
    public class TransactionTypes: Transaction
    {
        public int idSender {  get; set; }
        public int idReceiver { get; set; }

        public override void DoTransaction()
        {
            Console.WriteLine("Person {idSender} sent {idReceiver} amount:{amount}, at {time} ");
        }
    }
}
